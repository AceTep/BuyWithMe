using BuyWithMe.DAO;
using System;
using System.Data;
using System.Runtime.CompilerServices;
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

            //TODO - at the end of all the code above
            Initialize();
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            //TODO - at the end of all the code above
            Dao.DeleteRecord();
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


        #region Worker Methods

        private void Initialize() {
            ItemName.Text = "Enter Item";
            ItemPrice.Text = "0.00";
            Quantity.Text = "0";
            taxeble.Checked = false;
        }



        #endregion

    }
}
