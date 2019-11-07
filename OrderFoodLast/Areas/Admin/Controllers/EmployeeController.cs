using System;
using System.Collections.Generic;
using System.Dynamic;
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
            var r = _ctx.Roles.Where(p => p.RoleId == info.Role).SingleOrDefault();
            if (r != null)
            {
                ViewBag.Role = r.RoleName;
            }
            //ViewData["Emp"] = new SelectList(_ctx.Employee, "EmployeeId", "LastName", info.ManagerId);
            List<EmployeeInfo> list = _ctx.Employee.Select(p => new EmployeeInfo
            {
                ID = p.EmployeeId,
                Name = p.FirstName + " " + p.LastName
            }).ToList();
            ViewData["Emp"] = list;
            //Employee emp = _ctx.Employee.Where(p => p.EmployeeId == id).Include(o => o.Manager).Include(o => o.RoleNavigation).SingleOrDefault();
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
        
        public IActionResult Create()
        {
            LoginInfo info = HttpContext.Session.GetObject<LoginInfo>("Info");
            if (info.role == 3)
            {
                return BadRequest();
            }

            
            if (info.role == 1) // employee is super admin
            {
                var managers = _ctx.Employee.ToList();
                ViewBag.managers = managers;
            }
            else if (info.role == 2)
            {
                var managers = _ctx.Employee.Where(p => p.Role >= 2).ToList();
                ViewBag.managers = managers;
            }
            return View();
        }

        [HttpPost]
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

        public IActionResult Edit(int id)
        {
            int? checkRole = HttpContext.Session.GetObject<LoginInfo>("Info").role;
            Employee emp = _ctx.Employee.SingleOrDefault(p => p.EmployeeId == id);


            // xét quyền người đăng nhập có quyền được sửa không
            if (emp.Role <= checkRole && checkRole != 1)
            {
                return BadRequest();
            }

            List<object> data = new List<object>();
            data.Add(emp);
            var managers = _ctx.Employee.Where(p => p.Role < emp.Role && p.EmployeeId != id ).ToList();
            data.Add(managers);
            return View("Update", data);
        }

        [HttpPost]
        public IActionResult Edit(int id, IFormCollection data)
        {
            try
            {
                var info = HttpContext.Session.GetObject<LoginInfo>("Info");
                Employee emp = _ctx.Employee.SingleOrDefault(p=>p.EmployeeId== id);
                emp.LastName = data["lastName"];
                emp.FirstName = data["firstName"];
                emp.UserName = data["userName"];
                emp.Password = data["password"] != emp.Password ? MD5Hash(data["password"]) : emp.Password;
                emp.Address = data["address"];
                emp.Email = data["email"];
                emp.Phone = data["phone"];
                emp.BirthDate = DateTime.Parse(data["birthday"]);
                emp.Role = int.Parse(data["role"]);

                if (!String.IsNullOrEmpty(data["managerId"]))
                {
                    emp.ManagerId = int.Parse(data["managerId"]);
                }
                else
                {
                    emp.ManagerId = (int?)null;
                }

                emp.Status = int.Parse(data["status"]);
                emp.CreatedDate = DateTime.Now;
                emp.ModifiedBy = info.UserID;
                emp.ModifiedDate = DateTime.Now;
                _ctx.Employee.Update(emp);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }

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
        public IActionResult Delete(int id)
        {
            Employee emp = _ctx.Employee.SingleOrDefault(p => p.EmployeeId == id);
            _ctx.Employee.Remove(emp);
            _ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult GetManagerPeople(int idRole)
        {
            var roles = _ctx.Employee.Where(p => p.Role < idRole)
                                    .Select(s => new {id = s.EmployeeId, name = (s.FirstName + " " + s.LastName) }).ToList();
            return Ok(Json(roles));
        }

    }
}