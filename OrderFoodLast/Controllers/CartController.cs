using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderFoodLast.Helper;
using OrderFoodLast.Models;

namespace OrderFoodLast.Controllers
{
    [Route("Cart")]
    public class CartController : Controller
    {
        private readonly OrderFoodContext _ctx;
        private readonly IMapper _mapper;

        public CartController(OrderFoodContext db, IMapper mapper)
        {
            _ctx = db; _mapper = mapper;
        }

        public List<CartItem> Cart
        {
            get
            {
                var data = HttpContext.Session.GetObject<List<CartItem>>("Cart");
                if (data == null)
                {

                    data = new List<CartItem>();
                }
                return data;
            }
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Index(int? id)
        {
            var x = id;
            return View(Cart);
        }
        [Route("GetCartDetail/{CustomerId}")]
        public IActionResult GetCartDetail(int? CustomerId)
        {
            var cart = _ctx.Orders.Where(p => p.CustomerId == CustomerId).ToList();
            return View("CartDetail",cart);
        }

        [Route("addToCart/{id:int}")]
        public IActionResult AddToCart(int id)
        {
            List<CartItem> carts = Cart;
            CartItem item = carts.SingleOrDefault(c => c.Product.ProductId == id);

            

            if (item == null)
            {
                Product p = _ctx.Product.Find(id);
                carts.Add(new CartItem { Product = p, Quantity = 1, Total = p.Price});
                HttpContext.Session.SetObject("Cart", carts);
            }
            else
            {
                item.Quantity += 1;
                item.Total += item.Product.Price;
                HttpContext.Session.SetObject("Cart", carts);
            }
            return RedirectToAction("Index");
        }

        //public IActionResult RemoveCart(int id, string loai)
        //{
        //    List<CartItem> carts = Cart;

        //    CartItem item = carts.SingleOrDefault(p => p.Product.ProductId == id);
        //    if (item != null)
        //    {
        //        carts.Remove(item);

        //        HttpContext.Session.SetObject("GioHang", carts);
        //    }

        //    if (loai == "AJAX")
        //    {
        //        return Json(new
        //        {
        //            SoLuong = Cart.Sum(p => p.Quantity),
        //            TongTien = Cart.Sum(p => p.Total)
        //        });
        //    }

        //    return RedirectToAction("Index");
        //}
    }
}