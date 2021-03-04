using POS_System.Screens.ProductsF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Screens
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExitapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDefineProducts_Click(object sender, EventArgs e)
        {
            DefineProducts dp = new DefineProducts();
            dp.Show();
        }
    }
}
