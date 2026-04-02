using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPS_System_Design
{
    public partial class OrderManagement : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public OrderManagement()
        {
            InitializeComponent();
            SendMessage(textBox7.Handle, EM_SETCUEBANNER, 0, "Search here...");
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
