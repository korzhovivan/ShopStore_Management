using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopStore
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            SignIn authorizationWindow = new  SignIn();
            authorizationWindow.ShowDialog();
        }
    }
}
