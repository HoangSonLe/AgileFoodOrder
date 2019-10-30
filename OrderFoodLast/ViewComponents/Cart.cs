using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Helper;
using OrderFoodLast.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrderFoodLast.ViewComponents
{
    public class Cart : ViewComponent
    {
        public List<CartItem> Carts
        {
            get
            {
                var data = HttpContext.Session.GetObject<List<CartItem>>("Cart");
                if (data == null)
                {
                    data = new List<CartItem>();
                }
                return data;
            }
        }

        public IViewComponentResult Invoke()
        {
            return View("Default", Carts);
        }
    }
}