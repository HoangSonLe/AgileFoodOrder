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
        private readonly IMapper mapper;

        private readonly OrderFoodContext ctx;

        public ProductController(OrderFoodContext _ctx, IMapper _mapper)
        {
            ctx = _ctx;
            mapper = _mapper;
        }
        public IActionResult Index(int? id)
        {
            var productList = ctx.Product.AsQueryable();
            if (id.HasValue)
            {
                productList = productList.Where(p => p.ProductId == id);
            }


            //var products = mapper.Map<List<ProductView>>(productList.ToList());

            if (id.HasValue)
            {
                ProductCategory productCategory = ctx.ProductCategory.SingleOrDefault(p => p.CategoryId == id.Value);
                ViewBag.category = productCategory;
            }

            return View(productList);
        }
    }
}