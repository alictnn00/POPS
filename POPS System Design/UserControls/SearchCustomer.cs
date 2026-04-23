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

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            cmbSearchType.Items.Add("ID");
            cmbSearchType.Items.Add("Name");
            cmbSearchType.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string searchType = cmbSearchType.Text;

            CustomerRepository repo = new CustomerRepository();

            var results = repo.SearchCustomers(searchText, searchType);

            dgvCustomer.DataSource = results;
        }
    }
}
