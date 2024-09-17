using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.ComputerMonitor
{
    public class ComputerMonitorDetailDto
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
        public List<IFormFile> Images { get; set; }

        // ComputerMonitor Entity
        public string MonitorUserClass { get; set; }
        public string ScreenSize { get; set; }
        public string PannelType { get; set; }
        public string BackLight { get; set; }
        public string StatusContrast { get; set; }
        public string DisplayAspectRatio { get; set; }
        public string ScreenResolution { get; set; }
        public string ResponseTime { get; set; }
        public string VisualAngle { get; set; }
        public string MonitorTechnology { get; set; }
        public string UpdateRate { get; set; }
        public string ImagePort { get; set; }
        public string HdmiImagePort { get; set; }
        public string DisplayImagePort { get; set; }
        public string UsbPort { get; set; }
        public string Speaker { get; set; }
        public bool VesaSupport { get; set; }
        public bool RotationCapability { get; set; }
        public string PowerConsumption { get; set; }
    }
}
