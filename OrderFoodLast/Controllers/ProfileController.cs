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
    public class ProfileController : Controller
    {
        private readonly IMapper _mapper;

        private readonly OrderFoodContext _ctx;

        private List<Orders> list {
            get
            {
                LoginInfo info = HttpContext.Session.GetObject<LoginInfo>("Info");
                //Chỉ có khách hàng mới có hóa đơn
                if (info.position == "kh")
                {
                    return _ctx.Orders.Where(p => p.CustomerId == info.UserID).ToList();
                }
                return null;
            }
        }
        public ProfileController(OrderFoodContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            
            UserProfileView userProfile = new UserProfileView();
            LoginInfo info = HttpContext.Session.GetObject<LoginInfo>("Info");
            if (info == null) return Redirect("/");
            switch (info.position)
            {
                case "kh":
                    {
                        userProfile = _ctx.Customer.Where(p => p.CustomerId == info.UserID).Select(p => new UserProfileView
                        {
                            FirstName = p.FirstName,
                            LastName = p.LastName,
                            Address = p.Address,
                            Phone = p.Phone,
                            Email = p.Email
                        }).SingleOrDefault();
                        userProfile.orders = list;
                        break;
                    }
                case "nv":
                    {
                        userProfile = _ctx.Employee.Where(p => p.EmployeeId == info.UserID).Select(p => new UserProfileView
                        {
                            FirstName = p.FirstName,
                            LastName = p.LastName,
                            Address = p.Address,
                            Phone = p.Phone,
                            Email = p.Email
                        }).SingleOrDefault();
                        userProfile.orders = list;
                        break;

                    }
            }
            return View(userProfile);


        }

        [HttpPost]
        public IActionResult Index(UserProfileView userProfile)
        {
            if (ModelState.IsValid)
            {
                LoginInfo info = HttpContext.Session.GetObject<LoginInfo>("Info");
                switch (info.position)
                {
                    case "nv":
                        {
                            var nv = _ctx.Employee.Where(p => p.EmployeeId == info.UserID).SingleOrDefault();
                            if (nv != null)
                            {
                                nv.FirstName = userProfile.FirstName;
                                nv.LastName = userProfile.LastName;
                                nv.Email = userProfile.Email;
                                nv.Address = userProfile.Address;
                                nv.Phone = userProfile.Phone;
                                _ctx.Employee.Update(nv);
                                _ctx.SaveChanges();
                            }
                            break;
                        }
                    case "kh":
                        {
                            var cus = _ctx.Customer.Where(p => p.CustomerId == info.UserID).SingleOrDefault();
                            if (cus != null)
                            {
                                cus.FirstName = userProfile.FirstName;
                                cus.LastName = userProfile.LastName;
                                cus.Email = userProfile.Email;
                                cus.Address = userProfile.Address;
                                cus.Phone = userProfile.Phone;
                                _ctx.Customer.Update(cus);
                                _ctx.SaveChanges();
                            }
                            break;
                        }
                }
                info.Name = userProfile.FirstName + " " + userProfile.LastName;
                HttpContext.Session.SetObject<LoginInfo>("Info", info);
            }
            userProfile.orders = list;
            return View(userProfile);
        }
        public IActionResult ChangePassword(string oldPass, string newPass)
        {
            LoginInfo info = HttpContext.Session.GetObject<LoginInfo>("Info");
            switch (info.position)
            {
                case "nv":
                    {
                        var nv = _ctx.Employee.Where(p => p.EmployeeId == info.UserID).SingleOrDefault();
                        if (nv.Password == GetMD5(oldPass))
                        {
                            nv.Password = GetMD5(newPass);
                            _ctx.Employee.Update(nv);
                            _ctx.SaveChanges();
                            return Content("success");
                        }
                        return Content("fail");

                    }
                case "kh":
                    {
                        var cus = _ctx.Customer.Where(p => p.CustomerId == info.UserID).SingleOrDefault();
                        if (cus.Password == GetMD5(oldPass))
                        {
                            cus.Password = GetMD5(newPass);
                            _ctx.Customer.Update(cus);
                            _ctx.SaveChanges();
                            return Content("success");
                        }
                        return Content("fail");

                    }
            }
            return Content("fail");
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
    }
}