using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.Case
{
    public class CaseDetailDto
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

        // Case Entity
        [Display(Name = "محفظه درایو 3.5 اینچی")]
        public string Inch3_5DriveBay { get; set; }
        [Display(Name = "محفظه درایو 2.5 اینچی")]
        public string Inch2_5DriveBay { get; set; }
        [Display(Name = "روشنایی کیس")]
        public string CaseLighting { get; set; }
        [Display(Name = "بیشترین اندازه پنل سقفی خنک کننده")]
        public string MaxSizeOfCoolerCeilingPanel { get; set; }
        [Display(Name = "بیشترین اندازه پنل جلویی خنک کننده")]
        public string MaxSizeOfCoolerFrontPanel { get; set; }
        [Display(Name = "بیشترین اندازه پنل پشتی خنک کننده")]
        public string MaxSizeOfCoolerBackPanel { get; set; }
        [Display(Name = "حداکثر ارتفاع خنک کننده پردازنده")]
        public string MaximumCPUCoolerHeight { get; set; }
        [Display(Name = "حداکثر طول کارت گرافیک")]
        public string MaximumLengthOfGraphicCard { get; set; }
        [Display(Name = "تعداد منابع تغذیه که می توان نصب کرد")]
        public string NumberofPowerSuppliesThatCanBeInstalled { get; set; }
        [Display(Name = "محل نصب منبع تغذیه")]
        public string PowerSupplyInstallationLocation { get; set; }
        [Display(Name = "تعداد فن هایی که میتوانند در کیس نصب شوند")]
        public string NumberOfFansThatCanBeInstalledInCase { get; set; }
        [Display(Name = "تعداد فن های نصب شده در کیس")]
        public string NumberOfFanInstalledInCase { get; set; }
        [Display(Name = "تعداد فن های قابل نصب 120 میلی متر")]
        public string NumberOf120mmInstallableFans { get; set; }
        public string NumberOfInstalledFansIs140mm { get; set; }
        [Display(Name = "تعداد فن های نصب شده 140 میلی متری")]
        public string NumberOfFansThatCanBeInstalledonTheBack { get; set; }
        [Display(Name = "تعداد فن هایی که در جلو نصب شده اند")]
        public string NumberOfFansThatCanBeInstalledInTheFront { get; set; }
        [Display(Name = "تعداد فن هایی که که در سقف نصب شده اند")]
        public string NumberOfFansThatCanBeInstalledinTheCeiling { get; set; }
        [Display(Name = "تعداد پورت های USB کیس")]
        public string NumberofUSBPortsIs3Cases { get; set; }
        [Display(Name = "تعداد پورت های تایپ c ")]
        public string CaseUSBType_CPort { get; set; }
        [Display(Name = "کنترل کننده سرعت فن")]
        public bool CaseFanSpeedController { get; set; }
        [Display(Name = "کنترل کننده روشنایی فن")]
        public bool FancaseLightingController { get; set; }
        [Display(Name = "روشنایی")]
        public string Lighting { get; set; }
        [Display(Name = "ورودی میکروفن")]
        public bool MicrophoneInput { get; set; }
        [Display(Name = "خروجی هدفون")]
        public bool HeadPhoneOutPut { get; set; }
    }
}
