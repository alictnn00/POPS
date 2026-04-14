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
    public partial class MainFormProduction : Form
    {
        public MainFormProduction()
        {
            InitializeComponent();
            SetupLayout();
            NavigateTo(new ProductionHomePage());
        }

        private void SetupLayout()
        {
            btnProductionHomePageNav.Click += (s, e) => NavigateTo(new ProductionHomePage());
            btnProductionUpdateNav.Click += (s, e) => NavigateTo(new ProductionUpdate());


        }

        private void NavigateTo(UserControl screen)
        {
            MainViewPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            MainViewPanel.Controls.Add(screen);
        }


    }
}
