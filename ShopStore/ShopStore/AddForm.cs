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
    public partial class AddForm : Form
    {
        private DataContext dataContext;

        public AddForm(DataContext dataContext)
        {
            InitializeComponent();
            this.dataContext = dataContext;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Book new_bok = new Book()
            {
                Fio = txtBox_Fio.Text,
                PublishName = txtBox_PublishName.Text,
                NameBook = txtBox_BookName.Text,
                Price = Convert.ToInt32(txtBox_Price.Text),
                Pages = Convert.ToInt32(txtBox_Pages.Text),
                SalePrice = Convert.ToInt32(txtBox_SalePrice.Text),
                DateOfPublishing =  dateTimePicker.Value.Date
            };
            dataContext.GetTable<Book>().InsertOnSubmit(new_bok);
            dataContext.SubmitChanges();
            this.DialogResult = DialogResult.OK;
        }
    }
}
