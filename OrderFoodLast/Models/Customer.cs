﻿using System;
using System.Collections.Generic;

namespace OrderFoodLast.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Comment = new HashSet<Comment>();
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
