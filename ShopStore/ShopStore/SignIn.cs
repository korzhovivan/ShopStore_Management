using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Linq;
using System.Text.RegularExpressions;

namespace ShopStore
{
    public partial class SignIn : Form
    {
        public string password = null;
        public bool signInForm = true;
        public User currentUser = null;

        BookStoreEntities db = null;

        string admin_login = "admin1";
        string admin_pass = "admin1";

        public SignIn()
        {
            InitializeComponent();
            txtBox_password.PasswordChar = '*';
            this.FormClosed += SignIn_FormClosed;
            db = new BookStoreEntities();
            this.MaximumSize = new System.Drawing.Size(255, 383);
            this.MinimumSize = new System.Drawing.Size(255, 383);
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                
            }
            else
            {
                Application.Exit();
            }
        }

        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+){5}$");

            string input_login = txtBox_login.Text;
            string input_password = txtBox_password.Text;

            if (regex.Match(input_login).Success && regex.Match(input_password).Success)
            {
                txtBox_password.BackColor = Color.White;
                txtBox_login.BackColor = Color.White;

                if (signInForm) //SIGN IN
                {
                    //ADMIN
                    if (input_login == admin_login && input_password == admin_pass)
                    {
                        Admin adminForm = new Admin();

                        this.Hide();
                        if (adminForm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        int corect_login = db.Users.Where(user => user.Login == input_login).Count();

                        if (corect_login == 1)
                        {
                            var corect_password = db.Users.Where(user => user.Login == input_login).Where(user => user.Password == input_password.ToString()).Count();

                            if (corect_password == 1)
                            {
                                this.DialogResult = DialogResult.OK;
                                currentUser = new User() { Login = input_login, Password = password };

                            }
                            else
                            {
                                txtBox_password.BackColor = Color.PaleVioletRed;
                                MessageBox.Show("Incorrect password");
                            }
                        }
                        else
                        {
                            txtBox_login.BackColor = Color.PaleVioletRed;
                            MessageBox.Show("Incorrect username");
                        }
                    }//END
                } //END

                else //Create Acount
                {
                    using (BookStoreEntities db = new BookStoreEntities())
                    {
                        User newUser = new User() { Login = txtBox_login.Text, Password = txtBox_password.Text };
                        db.Users.Add(newUser);
                        db.SaveChanges();
                        MessageBox.Show("Created new user");
                    } 
                }//End 
            }
            else
            {
                if (!regex.Match(input_password).Success)
                {
                    txtBox_password.BackColor = Color.PaleVioletRed;
                }
                if(!regex.Match(input_login).Success)
                {
                    txtBox_login.BackColor = Color.PaleVioletRed;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (signInForm)
            {
                RegistarionState();
                signInForm = false;
            }
            else
            {
                SignInState();
                signInForm = true;
            }
        }
        public void RegistarionState()
        {
            txtBox_login.Text = "";
            txtBox_password.Text = "";

            this.Text = "Create account";
            label3.Text = "Have account?";
            linkLabel1.Text = "Sign In!";

            btn_SignIn.Text = "Create account";
            btn_SignIn.Width = 158;
            btn_SignIn.Height = 32;
        }
        public void SignInState()
        {
            txtBox_login.Text = "";
            txtBox_password.Text = "";

            this.Text = "Sign In";
            label3.Text = "No account?";
            linkLabel1.Text = "Create one!";

            btn_SignIn.Text = "Sign in";
            btn_SignIn.Width = 111;
            btn_SignIn.Height = 32;
        }
    }
}

