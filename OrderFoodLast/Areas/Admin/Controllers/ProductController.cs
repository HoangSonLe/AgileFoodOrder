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
using Microsoft.AspNetCore.Http;
using System.Net;

namespace OrderFoodLast.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly OrderFoodContext _ctx;
        private readonly IMapper _mapper;
        public ProductController(OrderFoodContext orderFoodContext, IMapper mapper)
        {
            _ctx = orderFoodContext;
            _mapper = mapper;
        }
        public IActionResult Index(int? page, string metaTitle)
        {
            int pageNumber = page ?? 0;
            int SoSP1Trang = 5;
            //List<ProductViewAdmin> productViewAdmins = GetDataListProductsView(pageNumber, metaTitle, SoSP1Trang);
            var category = _ctx.ProductCategory.Where(p => p.ParentId != null).ToList();
            ViewBag.productsView = GetDataListProductsView(pageNumber, metaTitle, SoSP1Trang); ;
            ViewBag.TongSoTrang = GetPaginationNumber(metaTitle, SoSP1Trang);
            ViewBag.SelectedPage = pageNumber;
            return View(category);
        }
        public int GetPaginationNumber(string metaTitle, int SoSP1Trang)
        {
            int pageNumber = 0;
            if (metaTitle != null)
            {
                pageNumber = (int)Math.Ceiling(1.0 * _ctx.Product.Where(p => p.Category.MetaTitle == metaTitle).Count() / SoSP1Trang);
            }
            else
            {
                pageNumber = (int)Math.Ceiling(1.0 * _ctx.Product.Count() / SoSP1Trang);
            };
            return pageNumber;
        }
        public List<ProductViewAdmin> GetDataListProductsView(int page, string metaTitle, int SoSP1Trang)
        {
            var products = _ctx.Product.Skip(page * SoSP1Trang).Take(SoSP1Trang).Include(p => p.Category).ToList();
            if (metaTitle != null)
            {
                products = _ctx.Product.Where(p => p.Category.MetaTitle == metaTitle).Skip(page * SoSP1Trang).Take(SoSP1Trang).Include(x => x.Category).ToList();
            }
            List<ProductViewAdmin> productViews = new List<ProductViewAdmin>();
            foreach (var p in products)
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
                catch (Exception e)
                {

                }
            }
            return productViews;
        }
        public IActionResult SelectProduct(int page, string metaTitle)
        {
            int pageNumber = page;
            int SoSP1Trang = 5;
            //List<ProductViewAdmin> productViewAdmins = GetDataListProductsView(pageNumber, metaTitle, SoSP1Trang);
            ViewBag.productsView = GetDataListProductsView(pageNumber, metaTitle, SoSP1Trang); ;
            ViewBag.TongSoTrang = GetPaginationNumber(metaTitle, SoSP1Trang);
            ViewBag.SelectedPage = pageNumber;
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

        public IActionResult SearchByName(int page, string metaTitle, string ProductName)
        {
            int SoSP1Trang = 5;
            var productsList = _ctx.Product.Include(p => p.Category).ToList();
            if (metaTitle!= null)
            {
                 productsList = _ctx.Product.Where(p => p.Category.MetaTitle == metaTitle).Include(p => p.Category).ToList();

            }
            var products = from p in productsList
                           where EF.Functions.Like(p.ProductName, $"%{ProductName}%")
                           select new ProductViewAdmin()
                           {
                               ProductId = p.ProductId,
                               ProductName = p.ProductName,
                               ProductImage = p.ProductImage,
                               Price = int.Parse(p.Price.ToString()),
                               Quantity = int.Parse(p.Quantity.ToString()),
                               Status = (p.Status == 0) ? "No Active" : "Active",
                               Category = p.Category.Name,
                               idCategory = p.Category.CategoryId
                           };
            products = products.Skip(page * SoSP1Trang).Take(SoSP1Trang);
            List<ProductViewAdmin> productViews = new List<ProductViewAdmin>();
            foreach (var p in products)
            {
                try
                {
                    productViews.Add(p);
                }
                catch (Exception e)
                {

                }
            }
            int pageNumber = page;
            //List<ProductViewAdmin> productViewAdmins = GetDataListProductsView(pageNumber, metaTitle, SoSP1Trang);
            ViewBag.productsView = productViews;
            ViewBag.TongSoTrang = (int)Math.Ceiling(1.0 * products.Count() / SoSP1Trang);
            ViewBag.SelectedPage = pageNumber;
            return PartialView("Filter");
        }
        //[Route("Admin/Product/{id}")]
        public IActionResult Update(int id)
        {
            Product product = _ctx.Product.Where(p=>p.ProductId == id)
                                          .Include(x=>x.Category)
                                          .Include(x=>x.CreatedByNavigation)
                                          .Include(x => x.ModifiedByNavigation)
                                          .SingleOrDefault();
            var categories = _ctx.ProductCategory.ToList();
            List<object> models = new List<object>();
            models.Add(product);
            models.Add(categories);
            return View("Detail",models);
        }

        [HttpPost]
        //[Route("Admin/Product/{id}")]
        public IActionResult Update(int id, IFormCollection data)
        {
            var product = _ctx.Product.SingleOrDefault(p => p.ProductId == id);


            product.ProductName = data["productName"];
            product.CategoryId = int.Parse(data["categoryID"]);
            product.Quantity = int.Parse(data["quantity"]);
            product.Price = int.Parse(data["price"]);
            product.PromotionPrice = int.Parse(data["promotionPrice"]);
            product.Description = data["description"];
            product.ModifiedDate = DateTime.Now;
            product.Status = int.Parse(data["status"]);
            product.IncludeVat = data["IncludeVat"]==1?true:false;
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
                return RedirectToAction("Index");
            }
            catch
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            return Content("Fail!");
        }
    }
}