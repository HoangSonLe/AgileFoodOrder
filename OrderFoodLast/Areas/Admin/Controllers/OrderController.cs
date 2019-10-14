using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderFoodLast.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Area("Admin")]
        [Route("Admin/Order/Edit/{id?}")]
        public IActionResult Edit(int id)
        {
            return View("Detail");
        }

    }
}