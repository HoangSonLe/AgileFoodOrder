using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderFoodLast.Models;

namespace OrderFoodLast.Controllers
{
    public class OrderController : Controller
    {
        private readonly IMapper _mapper;

        private readonly OrderFoodContext _ctx;

        public OrderController(OrderFoodContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        
        public IActionResult Index(int OrderID)
        {
            var order = _ctx.Orders.Where(p => p.OrderId == OrderID)
                                  .Join(
                                          _ctx.Customer,
                                          o => o.CustomerId,
                                          c => c.CustomerId,
                                          (o, c) => new OrderDetailView
                                          {
                                              cusFirstName = c.FirstName,
                                              cusLastName = c.LastName,
                                              cusAddress = c.Address,
                                              cusEmail = c.Email,
                                              cusPhone = c.Phone,
                                              comment = o.Comment,
                                              status = o.OrderStatus,
                                              total = o.Total,
                                          }
                                       ).SingleOrDefault();
            List<OrderDetail> list = _ctx.OrderDetail.Where(p => p.OrderId == OrderID).Include(x => x.Product).ToList();
            order.orderItems = list;
            return View(order);
        }
    }
}