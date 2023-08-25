using BuyWithMe.DAO;
using BuyWithMe.Models;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BuyWithMe
{
    public partial class MainForm : Form
    {
        public static IAppDao Dao;
        public static DataTable ItemData;

        #region Constructords
        public MainForm()
        {
            InitializeComponent();
        }

        static MainForm()
        {
            Dao = new AppDao();
            ItemData = Dao.CreateDataTable();
        }

        #endregion

        #region Event Handlers
        private void MainForm_Load(object sender, EventArgs e)
        {
    
            Initialize();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddItems();
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveAnItem();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //TODO - at the end of all the code above
            Dao.UpdateRecord();
        }

        private void loadList_Click(object sender, EventArgs e)
        {

        }

        private void saveList_Click(object sender, EventArgs e)
        {

        }
        private void shareList_Click(object sender, EventArgs e)
        {

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            var selection = MessageBox.Show("Do you want to exit?", "Exit BuyWithMe", MessageBoxButtons.YesNo);

            if (selection.ToString() == "Yes")
            {
                this.Close();
            }
            else
            { return; }
        }



        #region unused

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ItemPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #endregion


        #region Worker Methods

        private void Initialize() {
            ItemName.Text = "Enter Item";
            ItemPrice.Text = "0.00";
            ItemQuantity.Text = "0";
            taxeble.Checked = false;
        }

        private  bool AddItems()
        {
            try
            {
                var model = new ListModel();
                Regex rx = new Regex("[^A-Za-z0-9\\ ]");


                #region Validation

                //validation on item name
                if (!rx.IsMatch(ItemName.Text))
                {
                    model.ItemName = ItemName.Text;
                }
                else
                {
                    MessageBox.Show("You can not have special Characters. Please try again.");
                    return false;
                }

                //validation on item quantity
                if (short.TryParse(ItemQuantity.Text, out short quantity))
                {
                    model.ItemQuantity = quantity;
                }
                else
                {
                    MessageBox.Show("You must enter a valid quantity. Please try again.");
                    return false;
                }

                //validation on item price
                if (decimal.TryParse(ItemPrice.Text, out decimal price))
                {
                    model.ItemPrice = price * quantity;
                }
                else
                {
                    MessageBox.Show("You must enter a decimal value (e.g., 1.75). Please try again.");
                    return false;
                }

                //taxeble?

                model.Taxable = taxeble.Checked;


                #endregion

                Dao.AddRecord(ItemData,model);
                dataGridView1.DataSource = ItemData;
                Initialize();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem adding the record to the table: "+ex.Message);
                return false;
            }
        }

        private bool RemoveAnItem()
        {
            bool retVal = true;

            try
            {
                foreach (DataRow row in ItemData.Rows)
                {
                    var itemName = row["ItemName"].ToString();
                    var deleteDecision = MessageBox.Show($"Would you like to remove item {itemName}?", "Delete item?", MessageBoxButtons.YesNo);

                    if (deleteDecision.ToString() == "Yes")
                    {
                        Dao.DeleteRecord(ItemData, itemName);
                        return retVal;
                    }
                }
            }
            catch (Exception)
            {
                retVal = false;            
            }
            return retVal;
           
        }

        #endregion

    }
}
