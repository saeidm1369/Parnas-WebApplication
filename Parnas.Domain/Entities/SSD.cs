using Parnas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class SSD : BaseEntity<string>
    {
        public SSD()
        {

        }
        public string? SSDAppearance { get; set; }
        public string? Capacity { get; set; }
        public string? SSDInterface { get; set; }
        public string? SSDMemoryTechnology{ get; set; }
        public string? SSDPort { get; set; }
        public string? ReadingSpeed { get; set; }
        public string? WritingSpeed { get; set; }
        public string? Longevity { get; set; }

        #region Relations
        public ICollection<ProductImage> ProductImages { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
