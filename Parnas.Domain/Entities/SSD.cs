using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class SSD : BaseEntity<string> , IHasImage
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

        // IHasImage Properties
        public string ImageName { get; set; }
        public string ImagePath { get; set; }

        #region Relations
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
