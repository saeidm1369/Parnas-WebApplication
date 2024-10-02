using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.Power
{
    public class PowerDetailDto
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

        // Power Entity
        [Display(Name = "نوع اتصال منبع تغذیه")]
        public string PowerSupplyConnectionType { get; set; }

        [Display(Name = "توان نامی")]
        public string NominalPower { get; set; }

        [Display(Name = "استاندارد ATX 3.0")]
        public bool ATX3Standard { get; set; }

        [Display(Name = "نورپردازی فن منبع تغذیه")]
        public string PowerSupplyFanLighting { get; set; }

        [Display(Name = "اندازه فن منبع تغذیه")]
        public string PowerSupplyFanSize { get; set; }

        [Display(Name = "جریان +3.3 ولت")]
        public string Current33V { get; set; }

        [Display(Name = "جریان +5 ولت")]
        public string Plus5VCurrent { get; set; }

        [Display(Name = "جریان اولین ریل +12 ولت")]
        public string First12Current { get; set; }

        [Display(Name = "جریان 12 ولت")]
        public string v12VoltCurrent { get; set; }

        [Display(Name = "جریان +5VSB (استندبای)")]
        public string Current5VSBV { get; set; }

        [Display(Name = "اتصال 24 پین")]
        public string Pin24Connection { get; set; }

        [Display(Name = "اتصال 4+4 پین")]
        public string P4P4PinConnection { get; set; }

        [Display(Name = "اتصال 6+2 پین PCIe")]
        public string PinPcieConnection { get; set; }

        [Display(Name = "کانکتور 16 پین")]
        public string PinConnector { get; set; }

        [Display(Name = "کانکتور 15 پین SATA")]
        public string PinSataConnector { get; set; }

        [Display(Name = "گواهینامه 80Plus")]
        public string EighteenPlusCertificate { get; set; }

        [Display(Name = "استانداردهای حفاظت")]
        public string ProtectionStandards { get; set; }
    }
}
