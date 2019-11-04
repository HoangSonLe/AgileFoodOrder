using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Models;

namespace OrderFoodLast.Areas.Admin.Controllers
{ 
    [Area("Admin")]
    public class EmployeeController : Controller
    {
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
            Employee emp = new Employee()
            {
                LastName = data["lastName"],
                FirstName = data["firstName"],
                UserName = data["userName"],
                Password = MD5Hash(data["password"]),
                Address = data["address"],
                Phone = data["phone"],
                BirthDate = Convert.ToDateTime(data["birthday"]),
                Role = int.Parse(data["role"]),
                ManagerId = int.Parse(data["managerId"]),
                Status = int.Parse(data["status"])
            };
            return Ok(emp);
            //return View("Index");
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