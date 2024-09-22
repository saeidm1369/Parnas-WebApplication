using Parnas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class HDD : BaseEntity<string>
    {
        public HDD()
        {

        }
        public string Capacity { get; set; }
        public string TheAppearanceOfTheHardDrive { get; set; }
        public string HardDrivePort { get; set; }
        public string RotationSpeed { get; set; }
        public string HardDiskCachMemory { get; set; }
    }
}
