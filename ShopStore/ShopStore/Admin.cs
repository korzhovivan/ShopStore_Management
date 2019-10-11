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
    public partial class Admin : Form
    {
        private DataContext dataContext;

        public Admin()
        {
            InitializeComponent();

            dataGridView_Sales.DataSource = dataContext.GetTable<Sale>();
        }

        public Admin(DataContext dataContext)
        {
            this.dataContext = dataContext;
            InitializeComponent();

            dataGridView_Sales.DataSource = dataContext.GetTable<Sale>();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(dataContext);
            addForm.ShowDialog();
        }
    }
}
