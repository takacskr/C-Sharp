using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQJoin
{
    public class Order
    {
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliverDate { get; set; }
        public string? Note { get; set; }
    }

}
