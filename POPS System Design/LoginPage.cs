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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeeAuthentication repo = new EmployeeAuthentication();

            Employee emp = repo.AuthenticateEmployee(txtEmail.Text, txtPassword.Text);

            if (emp != null)
            {
                txtEmail.Clear();
                txtPassword.Clear();
                this.Hide();

                Form nextForm;

                if (emp.Department == "Sales")
                    nextForm = new MainFormSales();
                else if (emp.Department == "Production")
                    nextForm = new MainFormProduction();
                else
                    nextForm = new MainFormWarehouse();

                nextForm.ShowDialog(); // Blocks login form until closed

                this.Show(); // Opens login form after portal closes
                
            }
            else
            {
                MessageBox.Show("Invalid or missing credentials. Try again.");
            }

        }
    }
}
