using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Areas.Admin.Models;
using OrderFoodLast.Models;
using X.PagedList;

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
        public ActionResult Index(string seoTitle, int? page)
        {
            var categoryList = _ctx.ProductCategory.AsQueryable();
            List<ProductCategory> category = new List<ProductCategory>();
            List<Product> products = new List<Product>();
            category = categoryList.Where(p => p.MetaTitle == seoTitle)
                                    .Select(p => new ProductCategory
                                                    {
                                                        CategoryId = p.CategoryId
                                    }).ToList();
            products = category.Join(_ctx.Product,
                    c => c.CategoryId,
                    p => p.CategoryId,
                    (c, p) => new Product
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        ProductImage = p.ProductImage,
                        SeoTitle = p.SeoTitle,
                        Price = p.Price
                    }

                ).OrderBy(x=>x.ProductId).ToList();
            int pageNumber = page ?? 1;
            int pageSize = 8;


            ViewBag.seoTitle = seoTitle;
            return View(products.ToPagedList(pageNumber, pageSize));
        }
       
    }
}