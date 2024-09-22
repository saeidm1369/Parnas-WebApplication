using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class HDD : BaseEntity<int> , IHasImage
    {
        public HDD()
        {

        }
        public string? Capacity { get; set; }
        public string? TheAppearanceOfTheHardDrive { get; set; }
        public string? HardDrivePort { get; set; }
        public string? RotationSpeed { get; set; }
        public string? HardDiskCachMemory { get; set; }

        // IHasImage Properties
        public string? ImageName { get; set; }
        public string? ImagePath { get; set; }

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
