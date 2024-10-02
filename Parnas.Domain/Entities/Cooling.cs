using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.Cooling;

namespace Parnas.Domain.Entities
{
    public class Cooling : BaseEntity<int>, IHasImage<CoolingImage>
    {
        public Cooling()
        {

        }
        public string? IntelSocketSupport { get; set; }
        public string? AMDSocketSupport { get; set; }
        public string? TypeOfProccesorBlock { get; set; }
        public string? BlockLighting { get; set; }
        public string? FanConnection { get; set; }
        public string? NumberOfCoolingFans { get; set; }
        public string? TypeOfCoolingFan { get; set; }
        public string? CoolingFanRotationSpeed { get; set; }
        public string? FanLighting { get; set; }
        public string? PumpRotationSpeed { get; set; }
        public string? MaximumAirFlow { get; set; }
        public string? RadiatorMaterial { get; set; }
        public string? RadiatorDimensions { get; set; }
        public string? CoolingPipeLenght { get; set; }

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        // IHasImage Properties
        public List<CoolingImage> ImageList { get; set; } = new List<CoolingImage>();
        #endregion

        public class CoolingImage : ProductImage
        {
            public CoolingImage()
            {

            }
            public int CoolingId { get; set; }

            public Cooling Cooling { get; set; }
        }
    }
}
