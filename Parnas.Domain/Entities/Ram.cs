﻿using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class Ram : BaseEntity<int>
    {
        public Ram()
        {

        }
        public string? NumberOfPin { get; set; }
        public string? RamCooler { get; set; }
        public string? RomeLighting { get; set; }
        public string? TypeOfRamMemory { get; set; }
        public string? NumberOfModel { get; set; }
        public string? VolumeOfEachModules { get; set; }
        public string? TotalMemorySize { get; set; }
        public string? Ferequency { get; set; }

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
