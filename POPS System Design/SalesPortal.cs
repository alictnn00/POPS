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
    public partial class SalesPortal : Form
    {
        public SalesPortal()
        {
            InitializeComponent();
        }       

        private void btnOpenCustHub_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();
            this.Hide();
            customerManagement.ShowDialog();
            this.Show();
        }

        private void btnOpenOrderHub_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement = new OrderManagement();
            this.Hide();
            orderManagement.ShowDialog();
            this.Show();
        }
    }
    
}
