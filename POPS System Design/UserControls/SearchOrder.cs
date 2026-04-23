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

namespace POPS_System_Design.UserControls
{
    public partial class SearchOrder : UserControl
    {
        public SearchOrder()
        {
            InitializeComponent();
        }

        private void LoadOrders()
        {
            OrderRepository repo = new OrderRepository();
            dgvOrders.DataSource = repo.GetAllOrders();
        }

        private void LoadSearchType()
        {
            cmbSearchType.Items.Clear();

            cmbSearchType.Items.Add("Order ID");
            cmbSearchType.Items.Add("Customer Name");

            cmbSearchType.SelectedIndex = 0;
        }

        private void SearchOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
            UISetup();
            LoadSearchType();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int orderID = Convert.ToInt32(
                dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value
            );

            LoadOrderDetails(orderID);
        }

        private void LoadOrderDetails(int orderID)
        {
            OrderRepository repo = new OrderRepository();

            var details = repo.GetOrderDetails(orderID);

            dgvOrderDetails.DataSource = null;   // important reset
            dgvOrderDetails.DataSource = details;
        }

        private void UISetup()
        {
            dgvOrderDetails.AutoGenerateColumns = true;
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string searchType = cmbSearchType.SelectedItem.ToString();
            string keyword = txtSearch.Text.Trim();

            OrderRepository repo = new OrderRepository();

            // If empty → load all orders
            if (string.IsNullOrEmpty(keyword))
            {
                dgvOrders.DataSource = repo.GetAllOrders();
                return;
            }

            // Prevent crash for ID search
            if (searchType == "Order ID" && !int.TryParse(keyword, out _))
            {
                return; // just ignore invalid input while typing
            }

            dgvOrders.DataSource = repo.SearchOrders(searchType, keyword);

            dgvOrderDetails.DataSource = null; // clear details
        }
    }
}
