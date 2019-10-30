using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderFoodLast.Areas.Admin.Controllers
{ 
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Admin/Employee/{id}")]
        public IActionResult Detail()
        {
            return View();
        }
    }
}