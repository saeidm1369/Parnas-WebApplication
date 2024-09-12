using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.CPU
{
    public class CPUAddDto
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

        // CPU Entity
        public string Model { get; set; }
        public string Generation { get; set; }
        public string Socket { get; set; }
        public string CoreCount { get; set; }
        public string StringCount { get; set; }
        public string CoreE { get; set; }
        public string CoreP { get; set; }
        public string BaseFerequency { get; set; }
        public string BoostFerequency { get; set; }
        public string CachLevel2 { get; set; }
        public string CachLevel3 { get; set; }
        public string Technology { get; set; }
        public string CPUMemoryTechnology { get; set; }
        public string HDDFerequency { get; set; }
        public string CPUMaxHdd { get; set; }
        public string CPUMonitorCount { get; set; }
        public string PCIExpressCPU { get; set; }
        public string GraphicProccesor { get; set; }
        public string GraphicProccesorModel { get; set; }
        public string GraphicProccesorFerequency { get; set; }
        public string PowerCounsumption { get; set; }
        public string Packaging { get; set; }
    }
}
