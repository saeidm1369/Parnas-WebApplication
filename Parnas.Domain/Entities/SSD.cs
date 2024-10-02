using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.SSD;

namespace Parnas.Domain.Entities
{
    public class SSD : BaseEntity<int>, IHasImage<SSDImage>
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
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // IHasImage Properties
        public List<SSDImage> ImageList { get; set; } = new List<SSDImage>();
        #endregion

        public class SSDImage : ProductImage
        {
            public SSDImage()
            {

            }
            public int SSDId { get; set; }

            public SSD SSD { get; set; }
        }
    }
}
