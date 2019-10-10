using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopStore
{
    public partial class SignIn : Form
    {
        public string password = null;
        public DataContext dataContext = null;
        public bool signInForm = true;
        public User currentUser = null;

        public SignIn(DataContext dc)
        {
            InitializeComponent();
            txtBox_password.PasswordChar = '*';
            this.FormClosed += SignIn_FormClosed;
            dataContext = dc;
            this.MaximumSize = new System.Drawing.Size(278, 383);
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

            //input_login = "korzik";
            //input_password = "123456";

            if (regex.Match(input_login).Success && regex.Match(input_password).Success)
            {
                txtBox_password.BackColor = Color.White;
                txtBox_login.BackColor = Color.White;

                if (signInForm) //SIGN IN
                {
                    int corect_login = dataContext.GetTable<User>().Where(user => user.Login == input_login).Count();

                    if (corect_login == 1)
                    {
                        var corect_password = dataContext.GetTable<User>().Where(user => user.Login == input_login).Where(user => user.Password == input_password.ToString()).Count();

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
                    
                } //END

                else //Create Acount
                {
                    User new_user = new User() { Login = txtBox_login.Text, Password = txtBox_password.Text };
                    dataContext.GetTable<User>().InsertOnSubmit(new_user);
                    dataContext.SubmitChanges();
                    MessageBox.Show("Created new user");
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

