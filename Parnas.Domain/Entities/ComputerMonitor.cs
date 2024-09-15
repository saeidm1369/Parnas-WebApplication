using Parnas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class ComputerMonitor : BaseEntity<string>
    {
        public ComputerMonitor()
        {

        }
        public string? MonitorUserClass { get; set; }
        public string? ScreenSize { get; set; }
        public string? PannelType { get; set; }
        public string? BackLight { get; set; }
        public string? StatusContrast { get; set; }
        public string? DisplayAspectRatio { get; set; }
        public string? ScreenResolution { get; set; }
        public string? ResponseTime { get; set; }
        public string? VisualAngle { get; set; }
        public string? MonitorTechnology { get; set; }
        public string? UpdateRate { get; set; }
        public string? ImagePort { get; set; }
        public string? HdmiImagePort { get; set; }
        public string? DisplayImagePort { get; set; }
        public string? UsbPort { get; set; }
        public string? Speaker { get; set; }
        public bool VesaSupport { get; set; }
        public bool RotationCapability { get; set; }
        public string? PowerConsumption { get; set; }

        #region Relations
        public ICollection<ProductImage> ProductImages { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
