﻿using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.Power;

namespace Parnas.Domain.Entities
{
    public class Power : BaseEntity<int>, IHasImage<PowerImage>
    {
        public Power()
        {

        }
        public string? PowerSupplyConnectionType { get; set; }
        public string? NominalPower { get; set; }
        public bool ATX3Standard { get; set; }
        public string? PowerSupplyFanLighting { get; set; }
        public string? PowerSupplyFanSize { get; set; }
        public string? Current33V { get; set; }
        public string? Plus5VCurrent { get; set; }
        public string? First12Current { get; set; }
        public string? v12VoltCurrent { get; set; }
        public string? Current5VSBV { get; set; }
        public string? Pin24Connection { get; set; }
        public string? P4P4PinConnection { get; set; }
        public string? PinPcieConnection { get; set; }
        public string? PinConnector { get; set; }
        public string? PinSataConnector { get; set; }
        public string? EighteenPlusCertificate { get; set; }
        public string? ProtectionStandards { get; set; }

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // IHasImage Properties
        public List<PowerImage> ImageList { get; set; } = new List<PowerImage>();
        #endregion

        public class PowerImage : ProductImage
        {
            public PowerImage()
            {

            }
            public int PowerId { get; set; }

            public Power Power { get; set; }
        }
    }
}
