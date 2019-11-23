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
    public partial class EditForm : Form
    {
        BookStoreEntities db = null;
        public Book editBook = null;
        public EditForm(Book editObj)
        {
            InitializeComponent();
            db = new BookStoreEntities();

            editBook = editObj;

            txtBox_Fio.Text = editBook.Fio;
            txtBox_PublishName.Text = editBook.PublishName;
            txtBox_BookName.Text = editBook.NameBook;
            txtBox_Price.Text = editBook.Price.ToString();
            txtBox_Pages.Text = editBook.Pages.ToString();
            txtBox_SalePrice.Text = editBook.SalePrice.ToString();
            dateTimePicker.Value = editBook.DateOfPublishing;
            
        }
        private void btn_Edit_Click_1(object sender, EventArgs e)
        {
            editBook.DateOfPublishing = dateTimePicker.Value.Date;
            editBook.NameBook = txtBox_BookName.Text;
            editBook.Pages = Convert.ToInt32(txtBox_Pages.Text);
            editBook.Price = Convert.ToDecimal(txtBox_Price.Text);
            editBook.SalePrice = Convert.ToDecimal(txtBox_SalePrice.Text);
            editBook.PublishName = txtBox_PublishName.Text;
            editBook.Fio = txtBox_Fio.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}
