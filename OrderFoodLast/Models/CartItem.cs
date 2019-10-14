using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.Models
{
    public class CartItem
    {
        public ProductView Product { get; set; }
        public int Quantity { get; set; }
        public double Total => Quantity * Product.Price ;

    }
}
