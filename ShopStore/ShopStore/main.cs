using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Linq;

namespace ShopStore
{
    public partial class Main : Form
    {
        public SqlConnection SQL_conection = null;
        public DataContext dc = null;
        public User currUser = null;

        public Main()
        {
            InitializeComponent();

            SQL_conection = new SqlConnection();
            SQL_conection.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            dc = new DataContext(SQL_conection);

            SignIn signInForm = new SignIn(dc);
            if (signInForm.ShowDialog() == DialogResult.OK)
            {
                currUser = signInForm.currentUser;
                linkLable_login.Text = currUser.Login;
            }
            dataGridView_Books.DataSource = dc.GetTable<Book>();
           
            dataGridView_Cart.DataSource = (from item in dc.GetTable<Book>()
                                           join item2 in dc.GetTable<CartItem>() on item.ID_BOOK equals item2.Book_ID
                                           where item2.User_Login == currUser.Login
                                           select item).ToList();

            dataGridView_Cart.Columns["ID_BOOK"].Visible = false;
            dataGridView_Cart.Columns["Fio"].Visible = false;
            dataGridView_Cart.Columns["PublishName"].Visible = false;
            dataGridView_Cart.Columns["Price"].Visible = false;
            dataGridView_Cart.Columns["Pages"].Visible = false;
            dataGridView_Cart.Columns["DateOfPublishing"].Visible = false;
            dataGridView_Cart.Columns["SalePrice"].Visible = false;

            cmbBox_SortBy.SelectedIndexChanged += CmbBox_SortBy_SelectedIndexChanged;
            cmbBox_SortBy.Items.Add("Old");
            cmbBox_SortBy.Items.Add("New");
            cmbBox_SortBy.Items.Add("Name");
            cmbBox_SortBy.Items.Add("From lowest");
            cmbBox_SortBy.Items.Add("From highest");
        }

        private void CmbBox_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int filter = cmbBox_SortBy.SelectedIndex;

            switch (filter)
            {
                case 0: dataGridView_Books.DataSource = dc.GetTable<Book>().OrderBy(sort => sort.DateOfPublishing);
                    break;
                case 1:
                    dataGridView_Books.DataSource = dc.GetTable<Book>().OrderByDescending(sort => sort.DateOfPublishing);
                    break;
                case 2:
                    dataGridView_Books.DataSource = dc.GetTable<Book>().OrderBy(sort => sort.NameBook);
                    break;
                case 3:
                    dataGridView_Books.DataSource = dc.GetTable<Book>().OrderBy(sort => sort.Price);
                    break;
                case 4:
                    dataGridView_Books.DataSource = dc.GetTable<Book>().OrderByDescending(sort => sort.Price);
                    break;

            }
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            
            SignIn signInForm = new SignIn(dc);
            this.Hide();
            if (signInForm.ShowDialog() == DialogResult.OK)
            {
                currUser = signInForm.currentUser;
            }
            linkLable_login.Text = currUser.Login;
            this.Show();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if (dataGridView_Books.SelectedRows.Count == 1)
            {
                int index = dataGridView_Books.SelectedRows[0].Index;
                int ID = 0;
                if (Int32.TryParse(dataGridView_Books[0, index].Value.ToString(), out ID))
                {
                    var deleteObj = from item in dc.GetTable<Book>()
                                    where item.ID_BOOK == ID
                                    select item;
                    foreach (var item in deleteObj)
                    {
                        dc.GetTable<Book>().DeleteOnSubmit(item);
                        dc.SubmitChanges();
                    }
                } 
            }
            else
            {
                MessageBox.Show("Chose one book");
            }
            dataGridView_Books.DataSource = dc.GetTable<Book>().ToList();
            dataGridView_Books.Refresh();
            dataGridView_Books.Update();
            
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridView_Books.SelectedRows.Count == 1)
            {
                int index = dataGridView_Books.SelectedRows[0].Index;
                int ID = 0;
                if (Int32.TryParse(dataGridView_Books[0, index].Value.ToString(), out ID))
                {
                    CartItem cartItem = new CartItem() { Book_ID = ID,User_Login = currUser.Login};
                    dc.GetTable<CartItem>().InsertOnSubmit(cartItem);
                    dc.SubmitChanges();


                    dataGridView_Cart.DataSource = (from item in dc.GetTable<Book>()
                                                    join item2 in dc.GetTable<CartItem>() on item.ID_BOOK equals item2.Book_ID
                                                    where item2.User_Login == currUser.Login
                                                    select item).ToList();
                    dataGridView_Cart.Refresh();
                    dataGridView_Cart.Update();
                }
            }
            else
            {
                MessageBox.Show("Chose one book");
            }

            
        }
    }
}
