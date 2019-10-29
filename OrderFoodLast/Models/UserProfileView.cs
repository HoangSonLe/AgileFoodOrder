using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.Models
{
    public class UserProfileView
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage ="Họ tên không được để trống")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Tên không được để trống")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Địa chỉ không được để trống")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Email không được để trống")]
        [RegularExpression("^[a-zA-Z][a-zA-Z0-9]*([\\.\\-][a-zA-Z0-9]+)*@gmail.com$", ErrorMessage ="Email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Số điện thoại không được để trống")]
        [RegularExpression("0[3789][0-9]{8}",ErrorMessage ="Số điện thoại không hợp lệ")]
        public string Phone { get; set; }

        public List<Orders> orders { get; set; }
    }
}
