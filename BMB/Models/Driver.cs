using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMB.Models
{
    public class Driver
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDateTime { get; set; }
        public int TotalItems { get; set; }

    }
}