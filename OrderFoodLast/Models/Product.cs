using System;
using System.Collections.Generic;

namespace OrderFoodLast.Models
{
    public partial class Product
    {
        public Product()
        {
            Comment = new HashSet<Comment>();
            OrderDetail = new HashSet<OrderDetail>();
            ProductImages = new HashSet<ProductImages>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string SeoTitle { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public int? Price { get; set; }
        public int? PromotionPrice { get; set; }
        public bool? IncludeVat { get; set; }
        public int? Quantity { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? Status { get; set; }
        public int? ViewCounts { get; set; }

        public virtual ProductCategory Category { get; set; }
        public virtual Employee CreatedByNavigation { get; set; }
        public virtual Employee ModifiedByNavigation { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<ProductImages> ProductImages { get; set; }
    }
}
