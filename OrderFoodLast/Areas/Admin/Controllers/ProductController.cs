using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Models;
using OrderFoodLast.Areas.Admin.ModelViews;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

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
        public IActionResult Index(int? page, string metaTitle)
        {

            var products = _ctx.Product.Include(p => p.Category).ToList();
            if (metaTitle != null)
            {
                products = _ctx.Product.Where(p => p.Category.MetaTitle == metaTitle).Include(x => x.Category).ToList();
            }
            //idCategory = idCategory != null ? idCategory : 4;
            //var products = _ctx.Product.Where(p => p.Category.CategoryId == idCategory).Include(x=>x.Category).ToList();
            
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
                    productView.idCategory = p.Category.CategoryId;
                    productViews.Add(productView);
                }
                catch(Exception e)
                {

                }
            }
            int pageNumber = page ?? 1;
            var category = _ctx.ProductCategory.Where(p=> p.ParentId != null).ToList();
            ViewBag.productViews = productViews.ToPagedList(pageNumber, 5);
            ViewBag.category = category;
            ViewBag.metaTitle = metaTitle;
            return View(category);
        }
        public IActionResult SelectCategory(int? page, string metaTitle)
        {

            var products = _ctx.Product.Include(p => p.Category).ToList();
            if (metaTitle != null)
            {
                products = _ctx.Product.Where(p => p.Category.MetaTitle == metaTitle).Include(x => x.Category).ToList();
            }
            //idCategory = idCategory != null ? idCategory : 4;
            //var products = _ctx.Product.Where(p => p.Category.CategoryId == idCategory).Include(x=>x.Category).ToList();
            
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
                    productView.idCategory = p.Category.CategoryId;
                    productViews.Add(productView);
                }
                catch(Exception e)
                {

                }
            }
            int pageNumber = page ?? 1;
            var category = _ctx.ProductCategory.Where(p=> p.ParentId != null).ToList();
            ViewBag.productViews = productViews.ToPagedList(pageNumber, 5);
            ViewBag.category = category;
            ViewBag.metaTitle = metaTitle;
            return PartialView("Filter");
        }

        public IActionResult CreateOrEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = new Product();
            if (id != 0) product = _ctx.Product.Where(p => p.ProductId == id).Include(x => x.Category).SingleOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return PartialView("CreateOrEdit", product);
        }

    }
}