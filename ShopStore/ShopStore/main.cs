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

        public Main()
        {
            InitializeComponent();

            SQL_conection = new SqlConnection();
            SQL_conection.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            dc = new DataContext(SQL_conection);
            SignIn signInForm = new SignIn(dc);
            if (signInForm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
