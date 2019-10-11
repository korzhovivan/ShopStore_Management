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
        private DataContext dataContext;

        public Admin(DataContext dataContext)
        {
            this.dataContext = dataContext;
            InitializeComponent();

            dataGridView_Sales.DataSource = dataContext.GetTable<Sale>();
            dataGridView_Books.DataSource = dataContext.GetTable<Book>();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(dataContext);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                dataGridView_Books.DataSource = dataContext.GetTable<Book>().ToList();
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
                    var editObj = from item in dataContext.GetTable<Book>()
                                    where item.ID_BOOK == ID
                                    select item;

                    EditForm editForm = new EditForm(dataContext, editObj);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView_Books.DataSource = dataContext.GetTable<Book>().ToList();
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
                    var deleteObj = from item in dataContext.GetTable<Book>()
                                    where item.ID_BOOK == ID
                                    select item;
                    foreach (var item in deleteObj)
                    {
                        dataContext.GetTable<Book>().DeleteOnSubmit(item);
                        dataContext.SubmitChanges();
                    }
                }
            }
            dataGridView_Books.DataSource = dataContext.GetTable<Book>().ToList();
            dataGridView_Books.Refresh();
            dataGridView_Books.Update();
        }
    }
}
