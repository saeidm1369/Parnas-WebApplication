﻿using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.ComputerMonitor;

namespace Parnas.Domain.Entities
{
    public class ComputerMonitor : BaseEntity<int>, IHasImage<ComputerMonitorImage>
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
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        // IHasImage Properties
        public List<ComputerMonitorImage> ImageList { get; set; } = new List<ComputerMonitorImage>();
        #endregion
        public class ComputerMonitorImage : ProductImage
        {
            public ComputerMonitorImage()
            {

            }
            public int ComputerMonitorId { get; set; }

            public ComputerMonitor ComputerMonitor { get; set; }
        }
    }
}
