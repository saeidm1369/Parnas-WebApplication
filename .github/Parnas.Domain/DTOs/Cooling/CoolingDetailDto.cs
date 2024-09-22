using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.Cooling
{
    public class CoolingDetailDto
    {
        // Base Entity
        public string Id { get; set; }

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

        // Cooling Entity
        public string IntelSocketSupport { get; set; }
        public string AMDSocketSupport { get; set; }
        public string TypeOfProccesorBlock { get; set; }
        public string BlockLighting { get; set; }
        public string FanConnection { get; set; }
        public string NumberOfCoolingFans { get; set; }
        public string TypeOfCoolingFan { get; set; }
        public string CoolingFanRotationSpeed { get; set; }
        public string FanLighting { get; set; }
        public string PumpRotationSpeed { get; set; }
        public string MaximumAirFlow { get; set; }
        public string RadiatorMaterial { get; set; }
        public string RadiatorDimensions { get; set; }
        public string CoolingPipeLenght { get; set; }
    }
}
