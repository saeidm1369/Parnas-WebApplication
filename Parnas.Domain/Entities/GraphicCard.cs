using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class GraphicCard : BaseEntity<string> , IHasImage
    {
        public GraphicCard()
        {

        }
        public string? GraphicCardModel { get; set; }
        public string? GPUManuFacturer { get; set; }
        public string? GraphicCardProccesorGeneration { get; set; }
        public string? NumberOfGraphicCardFans { get; set; }
        public string? Lighting { get; set; }
        public string? MemoryType { get; set; }
        public string? MemorySize { get; set; }
        public string? MemorySpeed { get; set; }
        public string? BaseFerequencyOfTheGraphicsCard { get; set; }
        public string? BoostFerequensyOfTheGraphicsCard { get; set; }
        public string? InterfaceBandWidth { get; set; }
        public string? CudaCore { get; set; }
        public string? PciExpressGeneration { get; set; }
        public string? DirectXInterface { get; set; }
        public string? OpenGLInterface { get; set; }
        public bool HDCPSupport { get; set; }
        public bool FullHdSupport { get; set; }
        public bool K4Support { get; set; }
        public bool K8Support { get; set; }
        public string? MaximumResolution { get; set; }
        public string? SupportedDisplay { get; set; }
        public string? HdmiOutPutOfTheGraphicCard { get; set; }
        public string? DisplayPortOutputOfTheGraphicCard { get; set; }
        public string? GraphicsCardCooler { get; set; }
        public string? Slot { get; set; }
        public string? PowerConnector { get; set; }
        public string? RecommendedPower { get; set; }

        // IHasImage Properties
        public string ImageName { get; set; }
        public string ImagePath { get; set; }

        #region Relations
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
