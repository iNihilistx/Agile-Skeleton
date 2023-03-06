using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing3
{
    class clsOrderManagement
    {
        public int OrderId { get;  set; }
        public string ProductId { get; set; }
        public string CustomerId { get; set; }
        public int ProductQuantity { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get;  set; }

        public bool IsCanceled { get; set; }
    }
}
