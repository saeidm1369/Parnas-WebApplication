using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.HDD;

namespace Parnas.Domain.Entities
{
    public class HDD : BaseEntity<int>, IHasImage<HDDImage>
    {
        public HDD()
        {

        }
        public string? Capacity { get; set; }
        public string? TheAppearanceOfTheHardDrive { get; set; }
        public string? HardDrivePort { get; set; }
        public string? RotationSpeed { get; set; }
        public string? HardDiskCachMemory { get; set; }

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // IHasImage Properties
        public List<HDDImage> ImageList { get; set; } = new List<HDDImage>();
        #endregion

        public class HDDImage : ProductImage
        {
            public HDDImage()
            {

            }
            public int HDDId { get; set; }

            public HDD HDD { get; set; }
        }
    }
}
