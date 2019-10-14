using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Models;

namespace OrderFoodLast.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;

        private readonly OrderFoodContext _ctx;

        public ProductController(OrderFoodContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        public IActionResult Index(int? id)
        {
            var productList = _ctx.Product.AsQueryable();
            if (id.HasValue)
            {
                productList = productList.Where(p => p.ProductId == id);
            }


            //var products = mapper.Map<List<ProductView>>(productList.ToList());

            if (id.HasValue)
            {
                ProductCategory productCategory = _ctx.ProductCategory.SingleOrDefault(p => p.CategoryId == id.Value);
                ViewBag.category = productCategory;
            }

            return View(productList);
        }
    }
}