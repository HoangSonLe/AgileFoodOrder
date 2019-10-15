using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderFoodLast.Areas.Admin.Models;
using OrderFoodLast.Models;

namespace OrderFoodLast.Areas.Admin.Controllers
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

        [Area("Admin")]
        public IActionResult Index()
        {

            var orderList = _ctx.Orders.Join(_ctx.Customer,
                ord => ord.OrderId,
                cus => cus.CustomerId,

                (ord, cus) => new OrderView
                {
                    Id = ord.OrderId,
                    FullName = cus.FirstName + " " + cus.LastName,
                    Total = ord.Total,
                    ShipDate = ord.ShipDate
                }
            );
            return View(orderList);
        }

        [Area("Admin")]
        [Route("Admin/Order/Edit/{id?}")]
        public IActionResult Edit(int id)
        {
            return View("Detail");
        }

    }
}