using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.Power
{
    public class PoweAddDto
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

        // Power Entity
        public string PowerSupplyConnectionType { get; set; }
        public string NominalPower { get; set; }
        public bool ATX3Standard { get; set; }
        public string PowerSupplyFanLighting { get; set; }
        public string PowerSupplyFanSize { get; set; }
        public string Current33V { get; set; }
        public string Plus5VCurrent { get; set; }
        public string First12Current { get; set; }
        public string v12VoltCurrent { get; set; }
        public string Current5VSBV { get; set; }
        public string Pin24Connection { get; set; }
        public string P4P4PinConnection { get; set; }
        public string PinPcieConnection { get; set; }
        public string PinConnector { get; set; }
        public string PinSataConnector { get; set; }
        public string EighteenPlusCertificate { get; set; }
        public string ProtectionStandards { get; set; }
    }
}
