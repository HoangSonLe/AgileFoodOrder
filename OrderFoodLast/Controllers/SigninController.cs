using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Helper;
using OrderFoodLast.Models;


namespace OrderFoodLast.Controllers
{
    public class SigninController : Controller
    {
        private readonly OrderFoodContext _ctx;
        private readonly IMapper _mapper;

        public SigninController(OrderFoodContext db, IMapper mapper)
        {
            _ctx = db; _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        public string GetMD5(string str)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {

                sbHash.Append(String.Format("{0:x2}", b));

            }

            return sbHash.ToString();

        }
        [HttpPost]
        public IActionResult Login(string username, string password, string inlineRadioOptions)
        {
            bool isLoginSuccess = false;
            password = GetMD5(password);
            switch (inlineRadioOptions)
            {

                case "customer":
                {
                         var cus = _ctx.Customer.Where(p => p.UserName == username && p.Password == password).SingleOrDefault();
                         if (cus != null)
                         {
                             isLoginSuccess = true;
                             SaveSession(cus.CustomerId, cus.FirstName + " " + cus.LastName);
                         }
                        break;
                }
                case "employee":
                {
                        var employee = _ctx.Employee.Where(p => p.UserName == username && p.Password == password).SingleOrDefault();
                        if (employee != null)
                        {
                            isLoginSuccess = true;
                            SaveSession(employee.EmployeeId, employee.FirstName + " " + employee.LastName);
                        }
                        break;
                }
            }
            if (isLoginSuccess) return Redirect("/");
            return Redirect("/Signin?error=1");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetObject<LoginInfo>("Info", null);
            return Redirect("/");
        }
        public void SaveSession(int id, string name)
        {
            LoginInfo login = new LoginInfo
            {
                UserID = id,
                Name = name
            };
            HttpContext.Session.SetObject<LoginInfo>("Info", login);
        }
    }
}