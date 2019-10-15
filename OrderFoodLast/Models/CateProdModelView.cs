using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.Models
{
    public class CateProdModelView
    {
        public List<Product> products { get; set; }
        public List<ProductCategory> proCate { get; set; }
    }
}
