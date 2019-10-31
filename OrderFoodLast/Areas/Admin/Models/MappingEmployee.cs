using AutoMapper;
using OrderFoodLast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.Areas.Admin.Models
{
    public class MappingEmployee : Profile
    {
        public MappingEmployee()
        {
            CreateMap<Employee, EmployeeView>();
        }
    }
}
