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
    public partial class CreateOrder : UserControl
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void LoadCustomers()
        {
            CustomerRepository repo = new CustomerRepository();
            var customers = repo.GetAllCustomers();

            cmbCustomerID.DataSource = customers;
            cmbCustomerID.DisplayMember = "CustomerID";  
            cmbCustomerID.ValueMember = "CustomerID";
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadProducts();
            SetupOrderList();
            LoadSalesman();
        }

        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerID.SelectedItem is Customer cust)
            {
                txtCustomerName.Text = cust.FirstName + " " + cust.LastName;
            }
        }

        private void LoadProducts()
        {
            ProductRepository repo = new ProductRepository();
            var products = repo.GetAllProducts();

            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "DisplayText";
            cmbProduct.ValueMember = "ProductID";

            if (cmbProduct.SelectedItem is Product selectedProduct)
            {
                decimal price = selectedProduct.Price;
            }
        }

        private void SetupOrderList()
        {
            lvwOrderDetails.View = View.Details;
            lvwOrderDetails.FullRowSelect = true;
            lvwOrderDetails.GridLines = true;

            lvwOrderDetails.Columns.Clear();

            lvwOrderDetails.Columns.Add("ProductID", 80);
            lvwOrderDetails.Columns.Add("Product Name", 150);
            lvwOrderDetails.Columns.Add("Price", 80);
            lvwOrderDetails.Columns.Add("Quantity", 80);
            lvwOrderDetails.Columns.Add("Total", 100);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Enter a valid quantity");
                return;
            }

            Product product = (Product)cmbProduct.SelectedItem;

            bool found = false;

            foreach (ListViewItem item in lvwOrderDetails.Items)
            {
                int existingProductID = int.Parse(item.Text);

                if (existingProductID == product.ProductID)
                {
                    int existingQty = int.Parse(item.SubItems[3].Text);
                    int newQty = existingQty + qty;

                    item.SubItems[3].Text = newQty.ToString();
                    item.SubItems[4].Text = (newQty * product.Price).ToString("F2");

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                ListViewItem newItem = new ListViewItem(product.ProductID.ToString());
                newItem.SubItems.Add(product.ProductName);
                newItem.SubItems.Add(product.Price.ToString("F2"));
                newItem.SubItems.Add(qty.ToString());
                newItem.SubItems.Add((qty * product.Price).ToString("F2"));

                lvwOrderDetails.Items.Add(newItem);
            }

            txtQuantity.Clear();

            lblTotal.Text = "Order Total: $" + CalculateOrderTotal().ToString("F2");
        }

        private decimal CalculateOrderTotal()
        {
            decimal total = 0;

            foreach (ListViewItem item in lvwOrderDetails.Items)
            {
                total += decimal.Parse(item.SubItems[4].Text);
            }

            return total;
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (lvwOrderDetails.SelectedItems.Count > 0)
            {
                lvwOrderDetails.Items.Remove(lvwOrderDetails.SelectedItems[0]);
                lblTotal.Text = "Order Total: $" + CalculateOrderTotal().ToString("F2");
            }
        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            lvwOrderDetails.Items.Clear();
            cmbProduct.SelectedIndex = -1;
            txtQuantity.Clear();
            lblTotal.Text = "Order Total: $0.00";
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            if (cmbCustomerID.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer");
                return;
            }

            if (lvwOrderDetails.Items.Count == 0)
            {
                MessageBox.Show("Add at least one product");
                return;
            }

            int custID = (int)cmbCustomerID.SelectedValue;

            //Salesman Info
            int? empID = null;
            if (cmbSalesman.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a salesman");
                return;
            }
            else
            {
                empID = (int)cmbSalesman.SelectedValue;
            }

            OrderRepository repo = new OrderRepository();

            // 1. Create Order
            int orderID = repo.CreateOrder(custID, empID);


            // 2. Insert Order Details
            foreach (ListViewItem item in lvwOrderDetails.Items)
            {
                int productID = int.Parse(item.Text);
                decimal price = decimal.Parse(item.SubItems[2].Text);
                int qty = int.Parse(item.SubItems[3].Text);

                repo.AddOrderDetail(orderID, productID, price, qty);
            }

            MessageBox.Show("Order created successfully!");

            // 3. Reset UI
            lvwOrderDetails.Items.Clear();
            lblTotal.Text = "Total: $0.00";
        }


        private void LoadSalesman()
        {
            EmployeeRepository repo = new EmployeeRepository();
            var salesList = repo.GetSalesEmployees();

            cmbSalesman.DataSource = salesList;
            cmbSalesman.DisplayMember = "Name";   
            cmbSalesman.ValueMember = "EmpID";    
        }

        
    }
}
