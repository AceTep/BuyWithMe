using BuyWithMe.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BuyWithMe
{
    public partial class MainForm : Form
    {
        public static DataTable ItemData;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DemoDatabase1.mdf;Integrated Security=True");


        #region Constructords
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
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
            UpdateTableItem();
        }
        private void DeleteEverything_Click(object sender, EventArgs e)
        {
            var selection = MessageBox.Show("Do you want to Empty Shopping Cart?", "Empty Cart", MessageBoxButtons.YesNo);

            if (selection.ToString() == "Yes")
            {
                EmptyBin();
            }
            else
            { return; }
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


        #endregion


        #region Worker Methods

        internal void Initialize()
        {
            //filling empty text box
            ItemName.Text = "Enter Item";
            ItemPrice.Text = "0.00";
            ItemQuantity.Text = "0";

            //initilizing data


            SqlCommand command = new SqlCommand("select ItemName,ItemPrice,ItemQuantity, TotalPrice from ShoppingLists ORDER BY ID", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        internal void LoadData()
        {
            con.Open();


            // Using ExecuteScalar to get the sum of item prices
            SqlCommand itemPrice = new SqlCommand("select sum([TotalPrice]) from [dbo].[ShoppingLists]", con);
            object priceResult = itemPrice.ExecuteScalar();

            decimal Price;

            if (priceResult != DBNull.Value && decimal.TryParse(priceResult.ToString(), out decimal price))
            {
                Price = price;
            }
            else
            {
                Price = 0.00m; // Default value when result is DBNull or parsing fails
            }

            // Using ExecuteScalar to get the sum of item quantities
            SqlCommand itemQuantity = new SqlCommand("select SUM([ItemQuantity]) from ShoppingLists", con);
            object quantityResult = itemQuantity.ExecuteScalar();

            int Quantity;

            if (quantityResult != DBNull.Value && int.TryParse(quantityResult.ToString(), out int quantity))
            {
                Quantity = quantity;
            }
            else
            {
                Quantity = 0; // Default value when result is DBNull or parsing fails
            }
            TotalItems.Text = Quantity.ToString();
            TotalPrice.Text = Price.ToString("N2"); // Formatting price as a decimal
            con.Close();
        }





        internal bool AddItems()
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
                    model.ItemPrice = price;
                }
                else
                {
                    MessageBox.Show("You must enter a decimal value (e.g., 1.75). Please try again.");
                    return false;
                }

                #endregion
                model.TotalPrice = model.ItemPrice * model.ItemQuantity; // Calculate TotalPrice

                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DemoDatabase1.mdf;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO ShoppingLists (ItemName, ItemPrice, ItemQuantity, TotalPrice) VALUES (@ItemName, @ItemPrice, @ItemQuantity, @TotalPrice)", con);
                    command.Parameters.AddWithValue("@ItemName", model.ItemName);
                    command.Parameters.AddWithValue("@ItemPrice", model.ItemPrice);
                    command.Parameters.AddWithValue("@ItemQuantity", model.ItemQuantity);
                    command.Parameters.AddWithValue("@TotalPrice", model.TotalPrice);

                    command.ExecuteNonQuery();

                    LoadData();
                    Initialize();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem adding the record to the table: " + ex.Message);
                return false;
            }
        }

        private void RemoveAnItem()
        {
            con.Open();
            SqlCommand command = new SqlCommand("delete from ShoppingLists where  ItemName= '" + ItemName.Text + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            LoadData();
            Initialize();
        }
        private void EmptyBin()
        { 
            con.Open();
            SqlCommand command = new SqlCommand("delete from ShoppingLists", con);
            command.ExecuteNonQuery();
            con.Close();
            LoadData();
            Initialize();
        }
        private void UpdateTableItem()
        {
            con.Open();
            SqlCommand command = new SqlCommand("update ShoppingLists set ItemName='" + ItemName.Text + "',ItemPrice='" + decimal.Parse(ItemPrice.Text) +
                "',ItemQuantity='" + int.Parse(ItemQuantity.Text) + "',TotalPrice='"+(int.Parse(ItemQuantity.Text)* decimal.Parse(ItemPrice.Text)) +"' where ItemName= '" + ItemName.Text + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            LoadData();
            Initialize();

        }

        #endregion

   


    }
}
