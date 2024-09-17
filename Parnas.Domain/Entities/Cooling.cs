using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class Cooling : BaseEntity<string> , IHasImage
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

        // IHasImage Properties
        public string ImageName { get; set; }
        public string ImagePath { get; set; }

        #region Relations
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
