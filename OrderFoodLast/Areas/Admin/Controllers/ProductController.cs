using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Models;
using OrderFoodLast.Areas.Admin.ModelViews;
using Microsoft.EntityFrameworkCore;

namespace OrderFoodLast.Areas.Admin.Controllers
{
    [Area("Admin")] 
    public class ProductController : Controller
    {
        private readonly OrderFoodContext _ctx;
        private readonly IMapper _mapper;
        public ProductController(OrderFoodContext orderFoodContext,IMapper mapper)
        {
            _ctx = orderFoodContext;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var products = _ctx.Product.Include(p => p.Category).ToList();
            List<ProductViewAdmin> productViews = new List<ProductViewAdmin>();
            foreach(var p in products)
            {
                try
                {
                    ProductViewAdmin productView = new ProductViewAdmin();
                    productView.ProductId = p.ProductId;
                    productView.ProductName = p.ProductName;
                    productView.ProductImage = p.ProductImage;
                    productView.Price = int.Parse(p.Price.ToString());
                    productView.Quantity = int.Parse(p.Quantity.ToString());
                    productView.Status = (p.Status == 0) ? "No Active" : "Active";
                    productView.Category = p.Category.Name;
                    productViews.Add(productView);
                }
                catch(Exception e)
                {

                }
            }
            return View(productViews);
        }
    }
}