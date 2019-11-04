using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Helper;
using OrderFoodLast.Models;

namespace OrderFoodLast.Areas.Admin.Controllers
{ 
    [Area("Admin")]
    public class EmployeeController : Controller
    {
        private readonly OrderFoodContext _ctx;

        public EmployeeController(OrderFoodContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Admin/Employee/{id}")]
        public IActionResult Detail()
        {
            return View();
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

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

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
    }
}