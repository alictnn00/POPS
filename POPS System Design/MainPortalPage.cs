using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPS_System_Design
{
    public partial class MainPortalPage : Form
    {
        public MainPortalPage()
        {
            InitializeComponent();
        }
        private void MainPortalPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void btnOpenSale_Click(object sender, EventArgs e)
        {
            SalesPortal salesPortal = new SalesPortal();
            this.Hide();
            salesPortal.ShowDialog();
            this.Show();
        }

        private void btnOpenFact_Click(object sender, EventArgs e)
        {
            ProductHUB productHUB = new ProductHUB();
            this.Hide();
            productHUB.ShowDialog();
            this.Show();
        }

        private void btnOpenWare_Click(object sender, EventArgs e)
        {
            RawMaterialManagement rawMaterialManagement = new RawMaterialManagement();
            this.Hide();
            rawMaterialManagement.ShowDialog();
            this.Show();
        }
    }
}
