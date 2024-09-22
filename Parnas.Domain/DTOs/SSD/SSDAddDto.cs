using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.SSD
{
    public class SSDAddDto
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
        [Display(Name = "دسته بندی")]
        public int? CategoryId { get; set; }
        [Display(Name = "تصاویر ")]

        public List<IFormFile> Images { get; set; }

        // SSD Entity
        [Display(Name = "ظاهر SSD")]
        public string? SSDAppearance { get; set; }

        [Display(Name = "ظرفیت")]
        public string? Capacity { get; set; }

        [Display(Name = "رابط SSD")]
        public string? SSDInterface { get; set; }

        [Display(Name = "فناوری حافظه SSD")]
        public string? SSDMemoryTechnology { get; set; }

        [Display(Name = "پورت SSD")]
        public string? SSDPort { get; set; }

        [Display(Name = "سرعت خواندن")]
        public string? ReadingSpeed { get; set; }

        [Display(Name = "سرعت نوشتن")]
        public string? WritingSpeed { get; set; }

        [Display(Name = "طول عمر")]
        public string? Longevity { get; set; }
    }
}
