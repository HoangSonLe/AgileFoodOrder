using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Areas.Admin.Models;
using OrderFoodLast.Models;

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
        public IActionResult Index()
        {
            return View();
        }

        [Route("Admin/Employee/{id}")]
        public IActionResult Detail(int id)
        {
            Employee info;
            info = _ctx.Employee.Where(p => p.EmployeeId == id)
                            //.Select(p=>new EmployeeInfo
                            //{
                            //    ID=p.EmployeeId,
                            //    FirstName=p.FirstName,
                            //    LastName=p.LastName,
                            //    Username=p.UserName,
                            //    Address=p.Address,
                            //    Email=p.Email,
                            //    Phone=p.Phone,
                            //    BirthDate=p.BirthDate,
                            //    Role=p.Role,
                            //    Manager=p.ManagerId,
                            //    CreatedDate=p.CreatedDate,
                            //    CreatedBy=p.CreatedBy,
                            //    ModifiedDate=p.ModifiedDate,
                            //    ModifiedBy=p.ModifiedBy,
                            //    Status=p.Status
                            //})
                            .SingleOrDefault();
            return View(info);
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}