using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.Models
{
    public class ActionRequest
    {
        public string id { get; set; }
        public string qty { get; set; }
        public string total { get; set; }
    }
}
