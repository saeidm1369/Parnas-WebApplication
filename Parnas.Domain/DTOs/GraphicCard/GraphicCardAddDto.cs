using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.DTOs.GraphicCard
{
    public class GraphicCardAddDto
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

        // GraphicCard  Entity
        public string GraphicCardModel { get; set; }
        public string GPUManuFacturer { get; set; }
        public string GraphicCardProccesorGeneration { get; set; }
        public string NumberOfGraphicCardFans { get; set; }
        public string Lighting { get; set; }
        public string MemoryType { get; set; }
        public string MemorySize { get; set; }
        public string MemorySpeed { get; set; }
        public string BaseFerequencyOfTheGraphicsCard { get; set; }
        public string BoostFerequensyOfTheGraphicsCard { get; set; }
        public string InterfaceBandWidth { get; set; }
        public string CudaCore { get; set; }
        public string PciExpressGeneration { get; set; }
        public string DirectXInterface { get; set; }
        public string OpenGLInterface { get; set; }
        public bool HDCPSupport { get; set; }
        public bool FullHdSupport { get; set; }
        public bool K4Support { get; set; }
        public bool K8Support { get; set; }
        public string MaximumResolution { get; set; }
        public string SupportedDisplay { get; set; }
        public string HdmiOutPutOfTheGraphicCard { get; set; }
        public string DisplayPortOutputOfTheGraphicCard { get; set; }
        public string GraphicsCardCooler { get; set; }
        public string Slot { get; set; }
        public string PowerConnector { get; set; }
        public string RecommendedPower { get; set; }
    }
}
