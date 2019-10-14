using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Helper;
using OrderFoodLast.Models;

namespace BookStore.Controllers
{
    public class CartController : Controller
    {
        private readonly OrderFoodContext ctx;
        private readonly IMapper mapper;
        
        public CartController(OrderFoodContext db, IMapper _mapper)
        {
            ctx = db; mapper = _mapper;
        }

        public List<CartItem> Cart
        {
            get
            {
                var data = HttpContext.Session.GetObject<List<CartItem>>("GioHang");
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

        [HttpPost]
        public IActionResult AddToCart(int productId, int qty, string loai)
        {
            //Lấy giỏ hàng đang có ở Session
            List<CartItem> carts = Cart;

            //tìm xem đã có hàng hóa trong giỏ hàng với mã chọn hay chưa
            CartItem item = carts.SingleOrDefault(p => p.Product.ProductId == productId);
            if (item != null)//đã có
            {
                item.Quantity += qty;
            }
            else
            {
                Product hh = ctx.Product.SingleOrDefault(p => p.ProductId == productId);

                if (hh == null)//hàng hóa ko có trong Database
                    return RedirectToAction("Error", "Home");
                item = new CartItem
                {
                    Product = mapper.Map<ProductView>(hh),
                    Quantity = qty
                };

                carts.Add(item);
            }

            //update lại giỏ hàng
            HttpContext.Session.SetObject("GioHang", carts);

            if (loai == "AJAX")
            {
                return Json(new
                {
                    SoLuong = Cart.Sum(p => p.Quantity),
                    TongTien = Cart.Sum(p => p.Total)
                });
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoveCart(int id, string loai)
        {
            List<CartItem> carts = Cart;

            CartItem item = carts.SingleOrDefault(p => p.Product.ProductId == id);
            if (item != null)
            {
                carts.Remove(item);

                HttpContext.Session.SetObject("GioHang", carts);
            }

            if (loai == "AJAX")
            {
                return Json(new
                {
                    SoLuong = Cart.Sum(p => p.Quantity),
                    TongTien = Cart.Sum(p => p.Total)
                });
            }

            return RedirectToAction("Index");
        }
    }
}