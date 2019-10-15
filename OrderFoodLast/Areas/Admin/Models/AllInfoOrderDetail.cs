using OrderFoodLast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.Areas.Admin.Models
{
    public class AllInfoOrderDetail
    {
        public string cusName { get; set; }
        public string cusPhone { get; set; }
        public string cusAddress { get; set; }
        public string comment { get; set; }
        public int? status { get; set; }
        public List<OrderDetail> details { get; set; }
    }
}
