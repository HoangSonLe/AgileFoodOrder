using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Models;
using OrderFoodLast.Areas.Admin.Models;
using System.Dynamic;

namespace OrderFoodLast.Areas.Admin.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly OrderFoodContext _ctx;
        private readonly IMapper _mapper;

        public ProductController(OrderFoodContext db, IMapper mapper)
        {
            _ctx = db; _mapper = mapper;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Area("Admin")]
        [Route("Admin/Product/{id}")]
        public IActionResult Detail(int id)
        {
            Product product = _ctx.Product.Find(id);
            var category = _ctx.ProductCategory.Find(product.CategoryId);
            var employee = _ctx.Employee.Find(product.CreatedBy);
            var tmp = _ctx.Employee.Find(product.ModifiedBy);
            var employeeModified = tmp.FirstName + tmp.LastName;
            var categories = _ctx.ProductCategory.ToList();
            List<object> models = new List<object>();
            models.Add(product);
            models.Add(category);
            models.Add(employee);
            models.Add(categories);
            models.Add(employeeModified);
            return View(models);
        }

    }
}