using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.GraphicCard
{
    public class GraphicCardDetailDto
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
        [Display(Name = "تصاویر")]
        public List<string> Images { get; set; }

        // GraphicCard  Entity
        [Display(Name = "مدل کارت گرافیک")]
        public string GraphicCardModel { get; set; }

        [Display(Name = "سازنده GPU")]
        public string GPUManuFacturer { get; set; }

        [Display(Name = "نسل پردازنده کارت گرافیک")]
        public string GraphicCardProccesorGeneration { get; set; }

        [Display(Name = " تعداد فن‌های کارت گرافیک")]
        public string NumberOfGraphicCardFans { get; set; }

        [Display(Name = "نورپردازی")]
        public string Lighting { get; set; }

        [Display(Name = "نوع حافظه")]
        public string MemoryType { get; set; }

        [Display(Name = "حجم حافظه")]
        public string MemorySize { get; set; }

        [Display(Name = "سرعت حافظه")]
        public string MemorySpeed { get; set; }

        [Display(Name = "فرکانس پایه کارت گرافیک")]
        public string BaseFerequencyOfTheGraphicsCard { get; set; }

        [Display(Name = "فرکانس تقویتی کارت گرافیک")]
        public string BoostFerequensyOfTheGraphicsCard { get; set; }

        [Display(Name = "پهنای باند رابط")]
        public string InterfaceBandWidth { get; set; }

        [Display(Name = "هسته‌های CUDA")]
        public string CudaCore { get; set; }

        [Display(Name = "نسل PCI Express")]
        public string PciExpressGeneration { get; set; }

        [Display(Name = "رابط DirectX")]
        public string DirectXInterface { get; set; }

        [Display(Name = "رابط OpenGL")]
        public string OpenGLInterface { get; set; }

        [Display(Name = "پشتیبانی از HDCP")]
        public bool HDCPSupport { get; set; }

        [Display(Name = "پشتیبانی از Full HD")]
        public bool FullHdSupport { get; set; }

        [Display(Name = "پشتیبانی از 4K")]
        public bool K4Support { get; set; }

        [Display(Name = "پشتیبانی از 8K")]
        public bool K8Support { get; set; }

        [Display(Name = "حداکثر رزولوشن")]
        public string MaximumResolution { get; set; }

        [Display(Name = "نمایشگرهای پشتیبانی‌شده")]
        public string SupportedDisplay { get; set; }

        [Display(Name = "خروجی HDMI کارت گرافیک")]
        public string HdmiOutPutOfTheGraphicCard { get; set; }

        [Display(Name = "خروجی DisplayPort کارت گرافیک")]
        public string DisplayPortOutputOfTheGraphicCard { get; set; }

        [Display(Name = "خنک‌کننده کارت گرافیک")]
        public string GraphicsCardCooler { get; set; }

        [Display(Name = "اسلات")]
        public string Slot { get; set; }

        [Display(Name = "کانکتور برق")]
        public string PowerConnector { get; set; }

        [Display(Name = "توان پیشنهادی")]
        public string RecommendedPower { get; set; }
    }
}
