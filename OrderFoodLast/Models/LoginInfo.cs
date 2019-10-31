using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.Models
{
    public class LoginInfo
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string position { get; set; }
        public int? role { get; set; }
    }
}
