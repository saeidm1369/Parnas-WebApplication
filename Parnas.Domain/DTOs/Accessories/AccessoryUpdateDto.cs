using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.Accessories
{
    public class AccessoryUpdateDto
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
        public List<IFormFile> ImageList { get; set; }

        // Accessories Entity
        [Display(Name = "روشنایی")]
        public string? Lighting { get; set; }

        [Display(Name = "پورت اتصال")]
        public string? ConnectionPort { get; set; }

        [Display(Name = "نوع واسط")]
        public string? InterfaceType { get; set; }

        [Display(Name = "میکروفن")]
        public string? Microphone { get; set; }

        [Display(Name = "ورودی")]
        public string? Input { get; set; }

        [Display(Name = "خروجی")]
        public string? OutPut { get; set; }

        [Display(Name = "نوع کاربری")]
        public string? UserType { get; set; }

        [Display(Name = "کیفیت")]
        public string? Quality { get; set; }

        [Display(Name = "آنتی گوسینگ")]
        public bool? AntiGhosting { get; set; }

        [Display(Name = "سنسور")]
        public string? Sensor { get; set; }
    }
}
