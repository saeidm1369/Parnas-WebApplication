using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;
using static Parnas.Domain.Entities.Ram;

namespace Parnas.Domain.Entities
{
    public class Ram : BaseEntity<int>, IHasImage<RamImage>
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

        // IHasImage Properties
        public List<RamImage> ImageList { get; set; } = new List<RamImage>();
        #endregion

        public class RamImage : ProductImage
        {
            public RamImage()
            {

            }
            public int RamId { get; set; }

            public Ram Ram { get; set; }
        }
    }
}
