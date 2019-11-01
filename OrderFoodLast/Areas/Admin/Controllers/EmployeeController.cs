using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Areas.Admin.Models;
using OrderFoodLast.Models;
using X.PagedList;

namespace OrderFoodLast.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {

        private readonly OrderFoodContext _ctx;
        private readonly IMapper _mapper;
        public EmployeeController(OrderFoodContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        
        public IActionResult Index(int? page)
        {
            // danh sach employee trong model 
            var employeeList = _ctx.Employee.ToList();
            
            var employees = _mapper.Map<List<EmployeeView>>(employeeList);
            int pageNumber = page ?? 1;
            ViewBag.employeeViews = employees.ToPagedList(pageNumber, 1);

            return View(employees);


        }
    }
}