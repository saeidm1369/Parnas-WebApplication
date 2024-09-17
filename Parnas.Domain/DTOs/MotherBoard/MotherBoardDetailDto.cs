using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.MotherBoard
{
    public class MotherBoardDetailDto
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

        // MotherBoard  Entity
        public string Platform { get; set; }
        public string Chipset { get; set; }
        public string AppearanceOfTheMotherBoard { get; set; }
        public string ProccesorSocket { get; set; }
        public string SupportedProccesor { get; set; }
        public string MotherBoardMemoryTechnology { get; set; }
        public string MemorySlot { get; set; }
        public string Configuration { get; set; }
        public string MaximumMemorySize { get; set; }
        public string XmpSupport { get; set; }
        public string MainPowerConnector { get; set; }
        public string CPUPowerConnector { get; set; }
        public string PCIExperssX16Slot { get; set; }
        public string PCIExperssX16Generation { get; set; }
        public string M2Slot { get; set; }
        public string NumberOfSataPort { get; set; }
        public string RaidSupport { get; set; }
        public string MotherBoardDisplayPortOutput { get; set; }
        public string HdmiOutputOfTheMotherBoard { get; set; }
        public bool SoundChipset { get; set; }
        public bool Bluetooth { get; set; }
        public string BluetoothVersion { get; set; }
    }
}
