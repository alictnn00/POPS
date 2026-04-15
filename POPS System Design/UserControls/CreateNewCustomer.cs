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
    public partial class CreateNewCustomer : UserControl
    {
        public CreateNewCustomer()
        {
            InitializeComponent();
            //Calling Method to Load State Codes into ComboBox during initialization
            LoadStates();
        }
        private void LoadStates()
        {
            //Displaying State Codes in ComboBox
            cmbCustState.DataSource = StateData.GetStates();
            cmbCustState.SelectedIndex = -1;
        }

        private void CustomerControl_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreateNewCust_Click(object sender, EventArgs e)
        {
            try
            {
                //Address Object
                Address address = new Address()
                {
                    Street = txtCustStreet.Text,
                    City = txtCustCity.Text,
                    State = cmbCustState.Text,
                    Zip = txtCustZip.Text
                };

                //Customer Object
                Customer customer = new Customer()
                {
                    FirstName = txtCustFirstName.Text,
                    LastName = txtCustLastName.Text,
                    Email = txtCustEmail.Text,
                    Phone = mskCustPhone.Text,
                    Address = address
                };

                //Creating Repository Object
                CustomerRepository repo = new CustomerRepository();

                //Sending to CustomerRepository 
                int id =repo.AddCustomer(customer);

                //Displaying Confirmation Message
                MessageBox.Show($"Customer created with ID: {id}");

                //Reset Input Fields
                ResetCustomer();
            }
            catch (ArgumentException ex)
            {
                //Display Error Message for Invalid Input
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCustReset_Click(object sender, EventArgs e)
        {
            ResetCustomer();
        }
        
        private void ResetCustomer()
        {   
            //Clearing all input fields
            txtCustFirstName.Clear();
            txtCustLastName.Clear();
            txtCustEmail.Clear();
            mskCustPhone.Clear();
            txtCustStreet.Clear();
            txtCustCity.Clear();
            cmbCustState.SelectedIndex = -1; // Reset ComboBox selection
            txtCustZip.Clear();
        }
    }
}
