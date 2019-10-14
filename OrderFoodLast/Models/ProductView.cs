using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.Models
{
    public class ProductView
    {
        [Key]
        [Display(Name = "Mã hàng hóa")]
        public int ProductId { get; set; }
        [Display(Name = "Tên hàng hóa")]
        public string ProductName { get; set; }
        [MaxLength(150)]
        [Display(Name = "Hình")]
        public string ProductImage { get; set; }
        [Display(Name = "Đơn giá")]
        public double Price { get; set; }
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }
        public string ProductNameSeoUrl => ProductName.ToUrlFriendly();
    }
}
