using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.Ram
{
    public class RamAddDto
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
        [Display(Name = "تصاویر ")]

        public List<IFormFile> Images { get; set; }

        // Ram Entity
        [Display(Name = "تعداد پین")]
        public string NumberOfPin { get; set; }

        [Display(Name = "خنک‌کننده رم")]
        public string RamCooler { get; set; }

        [Display(Name = "نورپردازی RGB (در رم‌ها)")]
        public string RomeLighting { get; set; }

        [Display(Name = "نوع حافظه رم")]
        public string TypeOfRamMemory { get; set; }

        [Display(Name = "تعداد ماژول‌ها")]
        public string NumberOfModel { get; set; }

        [Display(Name = "حجم هر ماژول")]
        public string VolumeOfEachModules { get; set; }

        [Display(Name = "حجم کل حافظه")]
        public string TotalMemorySize { get; set; }

        [Display(Name = "فرکانس")]
        public string Ferequency { get; set; }
    }
}
