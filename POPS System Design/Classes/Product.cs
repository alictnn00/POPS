using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POPS_System_Design.Classes
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int InventoryAmount { get; set; }
        public string DisplayText => ProductName + " - $" + Price;

        public string InventoryLevel
        {
            get
            {
                if (InventoryAmount < 20) return "Low";
                if (InventoryAmount < 50) return "Medium";
                return "High";
            }

        }
    }
}
