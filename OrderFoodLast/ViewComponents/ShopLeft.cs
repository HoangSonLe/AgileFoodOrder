using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderFoodLast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodLast.ViewComponents
{
    public class ShopLeft : ViewComponent
    {
        private readonly IMapper _mapper;

        private readonly OrderFoodContext _ctx;

        public ShopLeft(OrderFoodContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var categoryList = _ctx.ProductCategory.AsQueryable();
            List<ProductCategory> categories = new List<ProductCategory>();
            categories = categoryList.Select(p => new ProductCategory
            {
                CategoryId = p.CategoryId,
                Name = p.Name,
                MetaTitle = p.MetaTitle,
                ParentId = p.ParentId
            }).ToList();
            
            return View("Default", categories);
        }
    }
}
