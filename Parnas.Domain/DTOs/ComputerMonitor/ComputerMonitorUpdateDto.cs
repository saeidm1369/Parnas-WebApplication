using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.ComputerMonitor
{
    public class ComputerMonitorUpdateDto
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

        // ComputerMonitor Entity
        [Display(Name = "کلاس کاربری مانیتور")]
        public string MonitorUserClass { get; set; }

        [Display(Name = "اندازه صفحه‌نمایش")]
        public string ScreenSize { get; set; }

        [Display(Name = "نوع پنل")]
        public string PannelType { get; set; }

        [Display(Name = "نور پس‌زمینه")]
        public string BackLight { get; set; }

        [Display(Name = "کنتراست ثابت")]
        public string StatusContrast { get; set; }

        [Display(Name = "نسبت ابعاد نمایش")]
        public string DisplayAspectRatio { get; set; }

        [Display(Name = "وضوح تصویر")]
        public string ScreenResolution { get; set; }

        [Display(Name = "زمان پاسخ‌دهی")]
        public string ResponseTime { get; set; }

        [Display(Name = "زاویه دید")]
        public string VisualAngle { get; set; }

        [Display(Name = "تکنولوژی مانیتور")]
        public string MonitorTechnology { get; set; }

        [Display(Name = "نرخ به‌روزرسانی")]
        public string UpdateRate { get; set; }

        [Display(Name = "پورت‌های تصویری")]
        public string ImagePort { get; set; }

        [Display(Name = "پورت HDMI")]
        public string HdmiImagePort { get; set; }

        [Display(Name = "پورت Display")]
        public string DisplayImagePort { get; set; }

        [Display(Name = "پورت USB")]
        public string UsbPort { get; set; }

        [Display(Name = "بلندگو")]
        public string Speaker { get; set; }

        [Display(Name = "پشتیبانی از VESA")]
        public bool VesaSupport { get; set; }

        [Display(Name = "قابلیت چرخش")]
        public bool RotationCapability { get; set; }

        [Display(Name = "مصرف برق")]
        public string PowerConsumption { get; set; }
    }
}
