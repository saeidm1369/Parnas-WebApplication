using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
     public class CPU : BaseEntity<string> , IHasImage
    {
        public CPU()
        {

        }
        public string? Model { get; set; }
        public string? Generation { get; set; }
        public string? Socket { get; set; }
        public string? CoreCount { get; set; }
        public string? StringCount { get; set; }
        public string? CoreE { get; set; }
        public string? CoreP { get; set; }
        public string? BaseFerequency { get; set; }
        public string? BoostFerequency { get; set; }
        public string? CachLevel2 { get; set; }
        public string? CachLevel3 { get; set; }
        public string? Technology { get; set; }
        public string? CPUMemoryTechnology { get; set; }
        public string? HDDFerequency { get; set; }
        public string? CPUMaxHdd { get; set; }
        public string? CPUMonitorCount { get; set; }
        public string? PCIExpressCPU { get; set; }
        public string? GraphicProccesor { get; set; }
        public string? GraphicProccesorModel { get; set; }
        public string? GraphicProccesorFerequency { get; set; }
        public string? PowerCounsumption { get; set; }
        public string? Packaging { get; set; }

        // IHasImage Properties
        public string ImageName { get; set; }
        public string ImagePath { get; set; }

        #region Relations
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
