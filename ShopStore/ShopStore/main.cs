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
using System.Net.Mail;
using System.Net;

namespace ShopStore
{
    public partial class Main : Form
    {
        BookStoreEntities db = null;
        public User currUser = null;
        
        int BOOK_ID = 0;
       
        
        public Main()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(938, 597); ;
            this.MaximumSize = new System.Drawing.Size(938, 597); ;

            db = new BookStoreEntities();

            SignIn signInForm = new SignIn();
            if (signInForm.ShowDialog() == DialogResult.OK)
            {
                currUser = signInForm.currentUser;
                linkLable_login.Text = currUser.Login;
            }
            else
            {
                return;
            }
            dataGridView_Books.DataSource = db.Books.ToList();

            dataGridView_Cart.DataSource = (from item in db.Books
                                            join item2 in db.Carts on item.ID_BOOK equals item2.Book_ID
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
                case 0:
                    dataGridView_Books.DataSource = db.Books.OrderBy(sort => sort.DateOfPublishing).ToList();
                    break;
                case 1:
                    dataGridView_Books.DataSource = db.Books.OrderByDescending(sort => sort.DateOfPublishing).ToList();
                    break;
                case 2:
                    dataGridView_Books.DataSource = db.Books.OrderBy(sort => sort.NameBook).ToList();
                    break;
                case 3:
                    dataGridView_Books.DataSource = db.Books.OrderBy(sort => sort.Price).ToList();
                    break;
                case 4:
                    dataGridView_Books.DataSource = db.Books.OrderByDescending(sort => sort.Price).ToList();
                    break;

            }
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {

            SignIn signInForm = new SignIn();
            this.Hide();
            if (signInForm.ShowDialog() == DialogResult.OK)
            {
                currUser = signInForm.currentUser;
            }
            linkLable_login.Text = currUser.Login;
            this.Show();
            dataGridView_Cart.DataSource = (from item in db.Books
                                            join item2 in db.Carts on item.ID_BOOK equals item2.Book_ID
                                            where item2.User_Login == currUser.Login
                                            select item).ToList();

        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            string nameOfBook = "";
                    var deleteObj = from item in db.Books
                                    where item.ID_BOOK == BOOK_ID
                                    select item;
            
            foreach (var item in deleteObj) {
                db.Books.Remove(item);
                nameOfBook = item.NameBook;
                Sale new_sale = new Sale() { ID_BOOK = BOOK_ID, Login = currUser.Login, DateOfSale = DateTime.Now, Price = item.SalePrice };
                        db.Sales.Add(new_sale);
            }
            db.SaveChanges();

            //Send to message
            string msg = "City: " + txtBox_City.Text + ", Post office: " + txtBox_Post.Text + ", Phone number: " + txtBox_Phone.Text + ", Book: " + nameOfBook; 
            MailMessage message = new MailMessage("korshow9999@gmail.com", "korzhoff.i@gmail.com", "order", msg);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            client.Credentials = new NetworkCredential("korshow9999@gmail.com", "KORZIK19");
            client.EnableSsl = true;
            client.Send(message);
            ///////////////////////////////////////////////////////////////////////

            dataGridView_Cart.DataSource = (from item in db.Books
                                            join item2 in db.Carts on item.ID_BOOK equals item2.Book_ID
                                            where item2.User_Login == currUser.Login
                                            select item).ToList();
            dataGridView_Books.DataSource = db.Books.ToList();
            dataGridView_Cart.Refresh();
            dataGridView_Cart.Update();

            groupBox1.Visible = false;
        
        }
        private void pictureBox_Cart_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cart.Visible)
            {
                dataGridView_Cart.Visible = false;
                btn_MakeOrder.Visible = false;
                
            }
            else
            {
                dataGridView_Cart.Visible = true;
                btn_MakeOrder.Visible = true;
                
            }
            dataGridView_Cart.ClearSelection();
        }
        void btn_AddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridView_Books.SelectedRows.Count == 1)
            {
                int index = dataGridView_Books.SelectedRows[0].Index;
                int ID = 0;
                if (Int32.TryParse(dataGridView_Books[0, index].Value.ToString(), out ID))
                {
                    
                    Cart cartItem = new Cart() { Book_ID = ID, User_Login = currUser.Login };
                    db.Carts.Add(cartItem);
                    db.SaveChanges();


                    dataGridView_Cart.DataSource = (from item in db.Books
                                                    join item2 in db.Carts on item.ID_BOOK equals item2.Book_ID
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

        private void btn_MakeOrder_Click(object sender, EventArgs e) {
            groupBox1.Visible = true;
            btn_Buy.Visible = true;
            if (dataGridView_Cart.SelectedRows.Count == 1) {
                int index = dataGridView_Cart.SelectedRows[0].Index;
                

                if (Int32.TryParse(dataGridView_Cart[0, index].Value.ToString(), out BOOK_ID)) {
                    var deleteObj = from item in db.Books
                                    where item.ID_BOOK == BOOK_ID
                                    select item;

                    foreach (var item in deleteObj) {

                        lbl_Price.Text = Convert.ToInt32(item.Price).ToString() + "$";
                        lbl_BookForBuy.Text = item.NameBook.ToString();
                    }
                }
            }
        }
    }
} 
