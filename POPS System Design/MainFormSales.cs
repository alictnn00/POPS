using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POPS_System_Design.UserControls;

namespace POPS_System_Design
{
    public partial class MainFormSales : Form
    {
        public MainFormSales()
        {
            InitializeComponent();
            SetupLayout();
            NavigateTo(new CreateNewCustomer());
        }

        private void SetupLayout()
        {
            btnCreateCustNav.Click += (s, e) => NavigateTo(new CreateNewCustomer());
            btnSearchCustNav.Click += (s, e) => NavigateTo(new SearchCustomer());
            btnCreateNewOrderNav.Click += (s, e) => NavigateTo(new CreateOrder());
            btnSearchOrderNav.Click += (s, e) => NavigateTo(new SearchOrder());

        }

        private void NavigateTo(UserControl screen)
        {
            MainViewPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            MainViewPanel.Controls.Add(screen); 

            
        }


    }
}
