using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.Case
{
    public class CaseAddDto
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
        public List<IFormFile> Images { get; set; }

        // Case Entity
        public string Inch3_5DriveBay { get; set; }
        public string Inch2_5DriveBay { get; set; }
        public string CaseLighting { get; set; }
        public string MaxSizeOfCoolerCeilingPanel { get; set; }
        public string MaxSizeOfCoolerFrontPanel { get; set; }
        public string MaxSizeOfCoolerBackPanel { get; set; }
        public string MaximumCPUCoolerHeight { get; set; }
        public string MaximumLengthOfGraphicCard { get; set; }
        public string NumberofPowerSuppliesThatCanBeInstalled { get; set; }
        public string PowerSupplyInstallationLocation { get; set; }
        public string NumberOfFansThatCanBeInstalledInCase { get; set; }
        public string NumberOfFanInstalledInCase { get; set; }
        public string NumberOf120mmInstallableFans { get; set; }
        public string NumberOfInstalledFansIs140mm { get; set; }
        public string NumberOfFansThatCanBeInstalledonTheBack { get; set; }
        public string NumberOfFansThatCanBeInstalledInTheFront { get; set; }
        public string NumberOfFansThatCanBeInstalledinTheCeiling { get; set; }
        public string NumberofUSBPortsIs3Cases { get; set; }
        public string CaseUSBType_CPort { get; set; }
        public bool CaseFanSpeedController { get; set; }
        public bool FancaseLightingController { get; set; }
        public string Lighting { get; set; }
        public bool MicrophoneInput { get; set; }
        public bool HeadPhoneOutPut { get; set; }
    }
}
