using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.HDD
{
    public class HDDUpdateDto
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

        // HDD Entity
        [Display(Name = "ظرفیت")]
        public string Capacity { get; set; }

        [Display(Name = "ظاهر هارد دیسک")]
        public string TheAppearanceOfTheHardDrive { get; set; }

        [Display(Name = "پورت هارد دیسک")]
        public string HardDrivePort { get; set; }

        [Display(Name = "سرعت چرخش")]
        public string RotationSpeed { get; set; }

        [Display(Name = "حافظه کش هارد دیسک")]
        public string HardDiskCachMemory { get; set; }
    }
}
