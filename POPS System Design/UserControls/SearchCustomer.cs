using POPS_System_Design.Classes;
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
    public partial class SearchCustomer : UserControl
    {
        public SearchCustomer()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            CustomerRepository repo = new CustomerRepository();

            var customers = repo.GetAllCustomers();

            dgvCustomer.DataSource = customers;
        }
    }
}
