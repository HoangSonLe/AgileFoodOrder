using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Models;

namespace OrderFoodLast.Controllers
{
    public class OrderController : Controller
    {
        private readonly IMapper mapper;

        private readonly OrderFoodContext ctx;

        public OrderController(OrderFoodContext _ctx, IMapper _mapper)
        {
            ctx = _ctx;
            mapper = _mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}