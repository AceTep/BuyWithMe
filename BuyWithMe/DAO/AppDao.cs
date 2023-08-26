using BuyWithMe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyWithMe.DAO
{

    public interface IAppDao
    {
        DataTable CreateDataTable();
        bool AddRecord(DataTable dt, ListModel model);
        void UpdateRecord(DataTable dt, ListModel model, int row);
        void DeleteRecord(DataTable dt, int row);
        void DeleteAllRecords();


    }

    public class AppDao : IAppDao
    {

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
