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
    public partial class ProductInventory : UserControl
    {
        public ProductInventory()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            ProductRepository repo = new ProductRepository();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = repo.GetAllProducts();
        }

        private void ProductInventory_Load(object sender, EventArgs e)
        {
            LoadProducts();
            GridLayout();
            LoadProductSearchType();
        }

        private void GridLayout()
        {
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProducts.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProducts.Columns["InventoryLevel"].HeaderText = "Inventory Status";
        }

        private void LoadProductSearchType()
        {
            cmbProductSearchType.Items.Clear();

            cmbProductSearchType.Items.Add("Product ID");
            cmbProductSearchType.Items.Add("Product Name");

            cmbProductSearchType.SelectedIndex = 0;
        }

        private void PerformProductSearch()
        {
            string searchType = cmbProductSearchType.SelectedItem.ToString();
            string keyword = txtProductSearch.Text.Trim();

            ProductRepository repo = new ProductRepository();

            // If empty → load all
            if (string.IsNullOrEmpty(keyword))
            {
                dgvProducts.DataSource = repo.GetAllProducts();
                return;
            }

            // Prevent crash for ID search
            if (searchType == "Product ID" && !int.TryParse(keyword, out _))
            {
                return;
            }

            dgvProducts.DataSource = repo.SearchProducts(searchType, keyword);
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            PerformProductSearch();
        }

        private void cmbProductSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformProductSearch();
        }
    }
}
