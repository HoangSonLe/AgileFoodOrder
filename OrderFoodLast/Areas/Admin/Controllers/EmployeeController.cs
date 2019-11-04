using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrderFoodLast.Areas.Admin.Models;
using OrderFoodLast.Helper;
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
        

        [Route("Admin/Employee/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("Admin/Employee/Create")]
        public IActionResult Create(IFormCollection data)
        {
            try
            {
                var info = HttpContext.Session.GetObject<LoginInfo>("Info");
                Employee emp = new Employee();
                emp.LastName = data["lastName"];
                emp.FirstName = data["firstName"];
                emp.UserName = data["userName"];
                emp.Password = MD5Hash(data["password"]);
                emp.Address = data["address"];
                emp.Email = data["email"];
                emp.Phone = data["phone"];
                emp.BirthDate = DateTime.Parse(data["birthday"]);
                emp.Role = int.Parse(data["role"]);
                emp.ManagerId = int.Parse(data["managerId"]);
                emp.Status = int.Parse(data["status"]);
                emp.CreatedDate = DateTime.Now;
                emp.CreatedBy = info.UserID;
                _ctx.Employee.Add(emp);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }
        }


        //[Route("Admin/Employee/Update/{id}")]
        public IActionResult Edit(int id)
        {
            Employee emp = _ctx.Employee.SingleOrDefault(p => p.EmployeeId == id);
            return View("Update",emp);
        }

        [HttpPost]
        //[Route("Admin/Employee/Update/{id}")]
        public IActionResult Edit(int id, IFormCollection data)
        {
            try
            {
                //var info = HttpContext.Session.GetObject<LoginInfo>("Info");
                Employee emp = _ctx.Employee.Find(id);
                emp.LastName = data["lastName"];
                emp.FirstName = data["firstName"];
                emp.UserName = data["userName"];
                emp.Password = data["password"] != emp.Password ? MD5Hash(data["password"]) : emp.Password;
                emp.Address = data["address"];
                emp.Email = data["email"];
                emp.Phone = data["phone"];
                emp.BirthDate = DateTime.Parse(data["birthday"]);
                emp.Role = int.Parse(data["role"]);
                
                emp.ManagerId = String.IsNullOrEmpty(data["managerId"])? 0:int.Parse(data["managerId"]);
                emp.Status = int.Parse(data["status"]);
                emp.CreatedDate = DateTime.Now;
                //emp.ModifiedBy = info.UserID;
                emp.ModifiedDate = DateTime.Now;
                _ctx.Employee.Update(emp);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }
            //
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(Encoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        [HttpPost]
        [Route("Admin/Employee/Delete")]
        public IActionResult Delete(int id)
        {
            Employee emp = _ctx.Employee.SingleOrDefault(p => p.EmployeeId == id);
            _ctx.Employee.Remove(emp);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}