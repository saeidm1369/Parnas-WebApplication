using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.MotherBoard
{
    public class MotherBoardUpdateDto
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

        // MotherBoard  Entity
        [Display(Name = "پلتفرم")]
        public string Platform { get; set; }

        [Display(Name = "چیپست")]
        public string Chipset { get; set; }

        [Display(Name = "ظاهر مادربورد")]
        public string AppearanceOfTheMotherBoard { get; set; }

        [Display(Name = "سوکت پردازنده")]
        public string ProccesorSocket { get; set; }

        [Display(Name = "پردازنده‌های پشتیبانی‌شده")]
        public string SupportedProccesor { get; set; }

        [Display(Name = "فناوری حافظه مادربورد")]
        public string MotherBoardMemoryTechnology { get; set; }

        [Display(Name = "اسلات حافظه")]
        public string MemorySlot { get; set; }

        [Display(Name = "پیکربندی")]
        public string Configuration { get; set; }

        [Display(Name = "حداکثر حجم حافظه")]
        public string MaximumMemorySize { get; set; }

        [Display(Name = "پشتیبانی از XMP")]
        public string XmpSupport { get; set; }

        [Display(Name = "کانکتور اصلی برق")]
        public string MainPowerConnector { get; set; }

        [Display(Name = "کانکتور برق پردازنده")]
        public string CPUPowerConnector { get; set; }

        [Display(Name = "اسلات PCI Express X16")]
        public string PCIExperssX16Slot { get; set; }

        [Display(Name = "نسل PCI Express X16")]
        public string PCIExperssX16Generation { get; set; }

        [Display(Name = "اسلات M.2")]
        public string M2Slot { get; set; }

        [Display(Name = "تعداد پورت SATA")]
        public string NumberOfSataPort { get; set; }

        [Display(Name = "پشتیبانی از RAID")]
        public string RaidSupport { get; set; }

        [Display(Name = "خروجی DisplayPort مادربورد")]
        public string MotherBoardDisplayPortOutput { get; set; }

        [Display(Name = "خروجی HDMI مادربورد")]
        public string HdmiOutputOfTheMotherBoard { get; set; }

        [Display(Name = "چیپست صدا")]
        public bool SoundChipset { get; set; }

        [Display(Name = "بلوتوث")]
        public bool Bluetooth { get; set; }

        [Display(Name = "نسخه بلوتوث")]
        public string BluetoothVersion { get; set; }
    }
}
