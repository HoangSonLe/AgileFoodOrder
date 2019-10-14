using System;
using System.Collections.Generic;

namespace OrderFoodLast.Models
{
    public partial class Slider
    {
        public int SlideId { get; set; }
        public string SliderImage { get; set; }
        public int? Display { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
