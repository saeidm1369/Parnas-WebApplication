using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class Gaming : BaseEntity<int> , IHasImage
    {
        public Gaming()
        {

        }
        public string? CPU { get; set; }
        public string? MotherBoard { get; set; }
        public string? Graphic { get; set; }
        public string? Ram { get; set; }
        public string? Hdd { get; set; }
        public string? DeepCool { get; set; }
        public string? Power { get; set; }
        public string? Case { get; set; }

        // IHasImage Properties
        public string? ImageName { get; set; }
        public string? ImagePath { get; set; }

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
