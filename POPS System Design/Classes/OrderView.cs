using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POPS_System_Design.Classes
{
    public class OrderView
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string SalesmanName { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
    }
}
