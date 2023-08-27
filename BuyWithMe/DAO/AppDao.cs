using BuyWithMe.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace BuyWithMe.DAO
{

    public interface IAppDao
    {
        DataTable CreateDataTable();
        bool AddRecord(DataTable dt, ListModel model); 
        bool AddSQLRecords(DataTable dt, IEnumerable<SelectItemsModel> models);
        IEnumerable<GetListsModel> GetListRows();
        IEnumerable<SelectItemsModel> GetListItems(GetListsModel model);
        void UpdateRecord(DataTable dt, ListModel model, int row);
        void DeleteRecord(DataTable dt, int row);
        void DeleteAllRecords();
    }

    public class AppDao : IAppDao
    {

        private string _connStr = "Data Source=MATEO-DELL;Initial Catalog=BuyWithMe;Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "TrustServerCertificate=False;ApplicationIntent=ReadOnly;MultiSubnetFailover=False";

        public DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable("Items");

            dataTable.Columns.Add("ItemName", typeof(string));
            dataTable.Columns.Add("ItemPrice", typeof(decimal));
            dataTable.Columns.Add("Quantity", typeof(short));

            return dataTable;
        }

        public bool AddRecord(DataTable dt, ListModel model)
        {
            try
            {
                DataRow row = dt.NewRow();
                row["ItemName"] = model.ItemName;
                row["ItemPrice"] = model.ItemPrice;
                row["Quantity"] = model.ItemQuantity;
                dt.Rows.Add(row);

                return true;
            }
            catch (Exception) 
            { 
                return false; 
            }
      
        }

        public bool AddSQLRecords(DataTable dt, IEnumerable<SelectItemsModel> models)
        {
            try
            {
                foreach (var model in models) {
                
                    DataRow row = dt.NewRow();
                    row["ItemName"] = model.sItemName;
                    row["ItemPrice"] = model.dItemPrice;
                    row["Quantity"] = model.iItemQuantity;
                    dt.Rows.Add(row);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public IEnumerable<GetListsModel> GetListRows() 
        {
            try
            {
                IEnumerable<GetListsModel> execSQL;
                using (SqlConnection conn = new SqlConnection(_connStr))
                {
                    conn.Open();
                    var pSQL = "EXEC [dbo].[ups_SelectExistingLists]";
                    execSQL = conn.Query<GetListsModel>(pSQL);
                }
                return execSQL;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
    
        }
         
        public IEnumerable<SelectItemsModel> GetListItems(GetListsModel model)
        {
            try
            {

                IEnumerable<SelectItemsModel> retSQL;
                using (SqlConnection conn = new SqlConnection(_connStr))
                {
                    conn.Open();

                     retSQL = conn.Query<SelectItemsModel>(@"SELECT [uUniqueID], " +
                        "[sItemName],[dItemPrice], [iItemQuantity], [sAddedBy], [tAddedDate], [sUpdatedBy], [tUpdatedDate], [bDeletedIndicator] " +
                        "FROM [dbo].[ShoppingLists] WITH (NOLOCK)WHERE tAddedDate = @Date ORDER BY dItemPrice, iItemQuantity", new { Date = model.TAddedDate });
                }
                return retSQL;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void UpdateRecord(DataTable dt, ListModel model, int row)
        {
            dt.Rows[row]["ItemName"] = model.ItemName;
            dt.Rows[row]["ItemPrice"] = model.ItemPrice;
            dt.Rows[row]["Quantity"] = model.ItemQuantity;
            dt.AcceptChanges();          
        }


        public void DeleteRecord(DataTable dt, int row)
        {
            dt.Rows[row].Delete();
            dt.AcceptChanges();
          
        }

        public void DeleteAllRecords()
        {

        }



    }
}
