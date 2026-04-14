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
    public partial class MainFormWarehouse : Form
    {
        public MainFormWarehouse()
        {
            InitializeComponent();
            SetupLayout();
            NavigateTo(new WarehouseHomePage());
        }

        private void SetupLayout()
        {
            btnHomeNav.Click += (s, e) => NavigateTo(new WarehouseHomePage());
            btnMatInvNav.Click += (s, e) => NavigateTo(new MaterialInventory());
            btnMatShipNav.Click += (s, e) => NavigateTo(new MaterialShipmentUpdate());
            btnProInvNav.Click += (s, e) => NavigateTo(new ProductInventory());
            btnProShipNav.Click += (s, e) => NavigateTo(new ProductShipment());

        }

        private void NavigateTo(UserControl screen)
        {
            MainViewPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            MainViewPanel.Controls.Add(screen);
        }


    }
}
