using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.FanCase
{
    public class FaneCaseAddDto
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

        // FanCase Entity
        public string FanCaseType { get; set; }
        public string FanCaseUsageType { get; set; }
        public bool FanCaseController { get; set; }
        public bool CaseFanSpeedController { get; set; }
        public string CaseFanNoiseLevel { get; set; }
        public string RatiotionSpeedOfTheCaseFan { get; set; }
        public string FanCaseLighting { get; set; }
        public string MaximumCaseAirFlow { get; set; }
        public bool FanCaseLightingController { get; set; }
    }
}
