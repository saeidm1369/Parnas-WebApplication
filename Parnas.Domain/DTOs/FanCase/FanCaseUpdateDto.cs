using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.FanCase
{
    public class FanCaseUpdateDto
    {
        // Base Entity

        public int Id { get; set; }

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

        // FanCase Entity
        [Display(Name = "نوع فن کیس")]
        public string FanCaseType { get; set; }
        [Display(Name = "نوع کاربرد فن کیس")]
        public string FanCaseUsageType { get; set; }
        [Display(Name = "کنترل‌کننده فن کیس")]
        public bool FanCaseController { get; set; }
        [Display(Name = " کنترل‌کننده سرعت فن کیس")]
        public bool CaseFanSpeedController { get; set; }
        [Display(Name = " سطح صدای فن کیس")]
        public string CaseFanNoiseLevel { get; set; }
        [Display(Name = "سرعت چرخش فن کیس")]
        public string RatiotionSpeedOfTheCaseFan { get; set; }
        [Display(Name = "نورپردازی فن کیس")]
        public string FanCaseLighting { get; set; }
        [Display(Name = "حداکثر جریان هوا در کیس")]
        public string MaximumCaseAirFlow { get; set; }
        [Display(Name = " کنترل‌کننده نورپردازی فن کیس")]
        public bool FanCaseLightingController { get; set; }
    }
}
