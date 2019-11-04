using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrderFoodLast.Areas.Admin.Models;
using OrderFoodLast.Models;
using X.PagedList;

namespace OrderFoodLast.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly IMapper _mapper;

        private readonly OrderFoodContext _ctx;

        public EmployeeController(OrderFoodContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }


        [Route("Admin/Employee/{id}")]
        public IActionResult Detail(int id)
        {
            Employee info;
            info = _ctx.Employee.Where(p => p.EmployeeId == id)
                            .SingleOrDefault();
            var role = _ctx.Roles.Find(info.Role);
            ViewData["Rol"] = new SelectList(_ctx.Roles, "RoleId", "RoleName", role.RoleId);
            //ViewData["Emp"] = new SelectList(_ctx.Employee, "EmployeeId", "LastName", info.ManagerId);
            List<EmployeeInfo> list = _ctx.Employee.Select(p => new EmployeeInfo
            {
                ID = p.EmployeeId,
                Name = p.FirstName + " " + p.LastName
            }).ToList();
            ViewData["Emp"] = list;
            return View(info);
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

        public IActionResult Edit()
        {
            return View();
        }
    }
}