using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopStore
{
    public partial class Admin : Form
    {
        BookStoreEntities db = null;
        List<string> month = null;
        public Admin()
        {
            InitializeComponent();
            db = new BookStoreEntities();

            cmbBox_Years.Items.Add("2017");
            cmbBox_Years.Items.Add("2018");
            cmbBox_Years.Items.Add("2019");

            cmbBox_Years.SelectedIndexChanged += CmbBox_Years_SelectedIndexChanged;

            dataGridView_Sales.DataSource = db.Sales.ToList();

            month = new List<string>()
            { 
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct",
                "Nov",
                "Dec"
            };
            

            

            chart1.ChartAreas[0].AxisX.Interval = 1;
            
            dataGridView_Books.DataSource = db.Books.ToList();
        }

        private void CmbBox_Years_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series["Profit"].Points.Clear();
            int year = 0;

            int index = cmbBox_Years.SelectedIndex;

            switch (index)
            {
                case 0: year = 2017; break;
                case 1: year = 2018; break;
                case 2: year = 2019; break;
            }
            var select = db.Sales.Where(g => g.DateOfSale.Year == year).GroupBy(s => s.DateOfSale.Month).Select(s => new { Month = s.Key, Profit = s.Sum(p => p.Price) });

            foreach (var item in select)
            {
                chart1.Series["Profit"].Points.AddXY(month[item.Month - 1], Convert.ToInt32(item.Profit).ToString());
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                dataGridView_Books.DataSource = db.Books.ToList();
                dataGridView_Books.Refresh();
                dataGridView_Books.Update();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Books.SelectedRows.Count == 1)
            {
                int index = dataGridView_Books.SelectedRows[0].Index;
                int ID = 0;
                if (Int32.TryParse(dataGridView_Books[0, index].Value.ToString(), out ID))
                {

                    var editObj = db.Books.Where(g => g.ID_BOOK == ID).Select(g => g).FirstOrDefault();


                    EditForm editForm = new EditForm(editObj);


                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        db.SaveChanges();
                        dataGridView_Books.DataSource = db.Books.ToList();
                        dataGridView_Books.Refresh();
                        dataGridView_Books.Update();
                    }
                } 
            }
            else
            {
                MessageBox.Show("Chose one book");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView_Books.SelectedRows.Count == 1)
            {
                int index = dataGridView_Books.SelectedRows[0].Index;
                int ID = 0;
                if (Int32.TryParse(dataGridView_Books[0, index].Value.ToString(), out ID))
                {
                    var deleteObj = from item in db.Books
                                    where item.ID_BOOK == ID
                                    select item;
                    foreach (var item in deleteObj)
                    {
                        db.Books.Remove(item);
                        
                    }
                }
            }
            db.SaveChanges();
            dataGridView_Books.DataSource = db.Books.ToList();
            dataGridView_Books.Refresh();
            dataGridView_Books.Update();
        }
    }
}
