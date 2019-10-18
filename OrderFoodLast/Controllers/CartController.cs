﻿using System;
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
        public IActionResult Index()
        {
            return View(Cart);
        }

        [Route("addToCart/{id:int}")]
        public IActionResult AddToCart(int id)
        {
            List<CartItem> carts = Cart;
            CartItem item = carts.SingleOrDefault(c => c.Product.ProductId == id);
            if (item == null)
            {
                Product p = _ctx.Product.Find(id);
                carts.Add(new CartItem { Product = p, Quantity = 1, Total = p.Price });
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
        [HttpPost]
        public IActionResult UpdateCart([FromBody] ActionRequest request)
        {
            var id = int.Parse(request.id);
            var qty = request.qty;
            var total = request.total;
            List<CartItem> carts = Cart;
            CartItem item = carts.SingleOrDefault(c => c.Product.ProductId == id);
            item.Quantity = int.Parse(qty);
            item.Total = int.Parse(total);
            HttpContext.Session.SetObject("Cart", carts);
            return Ok();
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