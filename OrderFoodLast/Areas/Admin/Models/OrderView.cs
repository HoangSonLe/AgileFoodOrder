using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.Areas.Admin.Models
{
    public class OrderView
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int? Total { get; set; }
        public DateTime? ShipDate { get; set; }
    }
}
