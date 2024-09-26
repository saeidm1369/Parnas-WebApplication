using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.Cooling
{
    public class CoolingAddDto
    {
        // Base Entity

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }

        [Display(Name = "برند")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Brand { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public decimal Price { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Description { get; set; }

        [Display(Name = "رنگ")]
        public string? Color { get; set; }

        [Display(Name = "اندازه")]
        public string? Dimensions { get; set; }

        [Display(Name = "وزن")]
        public string? Weight { get; set; }

        [Display(Name = "نوع")]
        public string? Type { get; set; }
        [Display(Name = "تعداد")]
        public int Count { get; set; }
        [Display(Name = "دسته بندی")]
        public int? CategoryId { get; set; }
        [Display(Name = "تصاویر")]
        public List<IFormFile> Images { get; set; }

        // Cooling Entity
        [Display(Name = "پشتیبانی از سوکت اینتل")]
        public string IntelSocketSupport { get; set; }
        [Display(Name = "پشتیبانی از سوکت AMD")]
        public string AMDSocketSupport { get; set; }
        [Display(Name = "نوع بلوک پردازنده")]
        public string TypeOfProccesorBlock { get; set; }
        [Display(Name = "نورپردازی بلوک")]
        public string BlockLighting { get; set; }
        [Display(Name = "اتصال فن")]
        public string FanConnection { get; set; }
        [Display(Name = "تعداد فن‌های خنک ‌کننده")]
        public string NumberOfCoolingFans { get; set; }
        [Display(Name = " نوع فن خنک ‌کننده")]
        public string TypeOfCoolingFan { get; set; }
        [Display(Name = "سرعت چرخش فن خنک‌ کننده")]
        public string CoolingFanRotationSpeed { get; set; }
        [Display(Name = " نورپردازی فن")]
        public string FanLighting { get; set; }
        [Display(Name = "سرعت چرخش پمپ")]
        public string PumpRotationSpeed { get; set; }
        [Display(Name = " حداکثر جریان هوا")]
        public string MaximumAirFlow { get; set; }
        [Display(Name = "جنس رادیاتور")]
        public string RadiatorMaterial { get; set; }
        [Display(Name = "ابعاد رادیاتور")]
        public string RadiatorDimensions { get; set; }
        [Display(Name = "طول لوله خنک ‌کننده")]
        public string CoolingPipeLenght { get; set; }
    }
}
