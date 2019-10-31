using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Areas.Admin.Models;
using OrderFoodLast.Models;

namespace OrderFoodLast.Areas.Admin.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly OrderFoodContext _ctx;
        private readonly IMapper _mapper;
        public EmployeeController(OrderFoodContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            // danh sach employee trong model 
            var employeeList = _ctx.Employee.ToList();
            
            var employees = _mapper.Map<List<EmployeeView>>(employeeList);
            return View(employees);
        }
    }
}