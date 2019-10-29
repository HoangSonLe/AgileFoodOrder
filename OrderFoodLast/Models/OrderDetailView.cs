using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.Models
{
    public class OrderDetailView
    {
        public string cusFirstName { get; set; }
        public string cusLastName { get; set; }
        public string cusPhone { get; set; }
        public string cusEmail { get; set; }
        public string cusAddress { get; set; }
        public string comment { get; set; }
        public int? status { get; set; }
        public int? total { get; set; }

        public List<OrderDetail> orderItems { get; set; }
    }
}
