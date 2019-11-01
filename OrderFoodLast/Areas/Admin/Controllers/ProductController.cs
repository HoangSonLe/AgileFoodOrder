using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Models;
using OrderFoodLast.Areas.Admin.Models;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace OrderFoodLast.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly OrderFoodContext _ctx;
        private readonly IMapper _mapper;

        public ProductController(OrderFoodContext db, IMapper mapper)
        {
            _ctx = db; _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

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

        [HttpPost]
        [Route("Admin/Product/{id}")]
        public IActionResult Update(int id, IFormCollection data)
        {
            var product = _ctx.Product.SingleOrDefault(p => p.ProductId == id);

            product.ProductName = data["bookName"];
            product.CategoryId = int.Parse(data["categoryID"]);
            product.Quantity = int.Parse(data["quantity"]);
            product.Price = int.Parse(data["price"]);
            product.Description = data["description"];
            product.Status = int.Parse(data["status"]);
            if (data["image"].Count() == 0)
            {
                product.ProductImage = data["image"];
            }
            try
            {
                _ctx.Product.Update(product);
                _ctx.SaveChanges();
                //  Success
                Response.StatusCode = (int)HttpStatusCode.OK;
                return View("Index");
            }
            catch
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            return Content("Fail!");
        }
    }
}