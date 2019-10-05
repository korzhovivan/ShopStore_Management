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
        bool correctLogin = false;
        public string login = null;
        public string password = null;
        public DataContext dataContext = null;

        public SignIn(DataContext dc)
        {
            InitializeComponent();
            txtBox_password.PasswordChar = '*';
            this.FormClosed += SignIn_FormClosed;
            dataContext = dc;
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
            Regex login_regex = new Regex("^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+){5}$");
            string login = txtBox_login.Text;

            if (login_regex.Match(login).Success)
            {
                txtBox_login.BackColor = Color.White;
                correctLogin = true;

                //var loignSuccess = from user in dataContext.GetTable<User>
                //                   where user.

            }
            else
            {
                txtBox_login.BackColor = Color.Red;
            }

            
        }

        [Table(Name = "User")]
        public class User
        {
            [Column(IsPrimaryKey = true, IsDbGenerated = true)]
            public int Id { get; set; }
            [Column]
            public string Login { get; set; }
            [Column]
            public string Passwod { get; set; }
        }
    }
}

