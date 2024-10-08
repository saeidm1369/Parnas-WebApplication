using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.Rendering
{
    public class RenderingAddDto
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

        // Rendering Entity
        [Display(Name = "پردازنده ")]
        public string CPU { get; set; }
        [Display(Name = "مادربرد")]
        public string MotherBoard { get; set; }
        [Display(Name = "کارت گرافیک")]
        public string Graphic { get; set; }
        [Display(Name = " حافظه رم")]
        public string Ram { get; set; }
        [Display(Name = "هارد دیسک")]
        public string Hdd { get; set; }
        [Display(Name = "خنک‌ کننده ")]
        public string DeepCool { get; set; }
        [Display(Name = "منبع تغذیه")]
        public string Power { get; set; }
        [Display(Name = "کیس")]
        public string Case { get; set; }
    }
}
