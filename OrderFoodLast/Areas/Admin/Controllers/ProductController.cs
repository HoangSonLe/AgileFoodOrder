using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Models;

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
            var model = _ctx.Product.Where(p => p.ProductId == id) as Product;
            return View(model);
        }

    }
}