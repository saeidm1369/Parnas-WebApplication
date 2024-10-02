using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.CPU
{
    public class CPUDetailDto
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
        [Display(Name = "تاریخ افزودن محصول")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "دسته بندی")]
        public int CategoryId { get; set; }
        [Display(Name = "تصاویر")]
        public List<string> ImageList { get; set; }

        // CPU Entity
        [Display(Name = "مدل")]
        public string Model { get; set; }
        [Display(Name = "نسل")]
        public string Generation { get; set; }
        [Display(Name = "سوکت")]
        public string Socket { get; set; }
        [Display(Name = "تعداد هسته")]
        public string CoreCount { get; set; }
        [Display(Name = "تعداد رشته")]
        public string StringCount { get; set; }
        [Display(Name = "هسته‌های کارآمد (E-Cores)")]
        public string CoreE { get; set; }
        [Display(Name = "هسته‌های قدرتمند (P-Cores)")]
        public string CoreP { get; set; }
        [Display(Name = "فرکانس پایه")]
        public string BaseFerequency { get; set; }
        [Display(Name = "فرکانس تقویت شده (بوست)")]
        public string BoostFerequency { get; set; }
        [Display(Name = "حافظه کش سطح ۲")]
        public string CachLevel2 { get; set; }
        [Display(Name = " حافظه کش سطح ۳")]
        public string CachLevel3 { get; set; }
        [Display(Name = "فناوری")]
        public string Technology { get; set; }
        [Display(Name = "فناوری حافظه پردازنده")]
        public string CPUMemoryTechnology { get; set; }
        [Display(Name = "فرکانس هارد دیسک")]
        public string HDDFerequency { get; set; }
        [Display(Name = "حداکثر هارد دیسک پشتیبانی شده توسط CPU")]
        public string CPUMaxHdd { get; set; }
        [Display(Name = "تعداد نمایشگرهای پشتیبانی شده توسط CPU")]
        public string CPUMonitorCount { get; set; }
        [Display(Name = "تعداد خطوط PCI Express پردازنده")]
        public string PCIExpressCPU { get; set; }
        [Display(Name = " پردازنده گرافیکی")]
        public string GraphicProccesor { get; set; }
        [Display(Name = "مدل پردازنده گرافیکی")]
        public string GraphicProccesorModel { get; set; }
        [Display(Name = "فرکانس پردازنده گرافیکی")]
        public string GraphicProccesorFerequency { get; set; }
        [Display(Name = "مصرف برق")]
        public string PowerCounsumption { get; set; }
        [Display(Name = "بسته‌بندی ")]
        public string Packaging { get; set; }
    }
}
