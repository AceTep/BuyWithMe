using BuyWithMe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyWithMe
{
    public partial class DisplayExistingLists : Form
    {
        private IEnumerable<GetListsModel> _listModel;
        private CultureInfo cultureInf = new CultureInfo("hr-HR");
        public GetListsModel retModel;
        public DisplayExistingLists(IEnumerable<GetListsModel> model)
        {
            InitializeComponent();
            _listModel = model;
        }


        private void DisplayExistingLists_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _listModel;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectList_Click(object sender, EventArgs e)
        {
            SelectListModel();
            Close();
        }
          

        public void SelectListModel()
        {
            retModel = null;
            try 
            {
                var selections = dataGridView1.CurrentCell.RowIndex;
                var uniqueCnt = Convert.ToInt32(dataGridView1.Rows[selections].Cells[0].Value);

                var dateT = dataGridView1.Rows[selections].Cells[1].Value.ToString();

                DateTime.TryParseExact(dateT,
                    "ddMMyyyy",
                    cultureInf,
                    DateTimeStyles.None, out DateTime outDate);
                var uniqueDate = dataGridView1.Rows[selections].Cells[1].Value;

                retModel = _listModel.Where(x => x.UniqueCount == uniqueCnt && x.TAddedDate == outDate.ToString("ddMMyyyy"))
                    .Select(x => new GetListsModel { TAddedDate = x.TAddedDate, UniqueCount = x.UniqueCount }).FirstOrDefault();
            }
            catch (Exception) 
            {
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            var selection = MessageBox.Show("Do you want to exit?", "Exit BuyWithMe", MessageBoxButtons.YesNo);

            if (selection.ToString() == "Yes")
            {
                this.Close();
            }
            else
            { return; }
        }
    }
}
