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
        public string login = null;
        public string password = null;
        public DataContext dataContext = null;

        public SignIn(DataContext dc)
        {
            InitializeComponent();
            txtBox_password.PasswordChar = '*';
            this.FormClosed += SignIn_FormClosed;
            dataContext = dc;
            this.MaximumSize = new System.Drawing.Size(277, 362);
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

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+){5}$");

            string input_login = txtBox_login.Text;
            string input_password = txtBox_password.Text;

            if (regex.Match(input_login).Success && regex.Match(input_password).Success)
            {
                txtBox_password.BackColor = Color.White;
                txtBox_login.BackColor = Color.White;

                int corect_login = dataContext.GetTable<User>().Where(user => user.Login == input_login).Count();

                if (corect_login == 1)
                {
                    
                    var corect_password = dataContext.GetTable<User>().Where(user => user.Login == input_login).Where(user => user.Password == input_password.ToString()).Count();

                    if (corect_password == 1)
                    {
                        MessageBox.Show("Enter!!!!!!!!!!!!!!!");
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
    }
}

