using System;
using System.Collections.Generic;

namespace OrderFoodLast.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Comment = new HashSet<Comment>();
            InverseManager = new HashSet<Employee>();
            Orders = new HashSet<Orders>();
            ProductCategoryCreatedByNavigation = new HashSet<ProductCategory>();
            ProductCategoryModifiedByNavigation = new HashSet<ProductCategory>();
            ProductCreatedByNavigation = new HashSet<Product>();
            ProductModifiedByNavigation = new HashSet<Product>();
        }

        public int EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Role { get; set; }
        public int? ManagerId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? Status { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual Roles RoleNavigation { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Employee> InverseManager { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<ProductCategory> ProductCategoryCreatedByNavigation { get; set; }
        public virtual ICollection<ProductCategory> ProductCategoryModifiedByNavigation { get; set; }
        public virtual ICollection<Product> ProductCreatedByNavigation { get; set; }
        public virtual ICollection<Product> ProductModifiedByNavigation { get; set; }
    }
}
