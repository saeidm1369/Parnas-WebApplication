using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.Gaming;

namespace Parnas.Domain.Entities
{
    public class Gaming : BaseEntity<int>, IHasImage<GamingImage>
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

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // IHasImage Properties
        public List<GamingImage> ImageList { get; set; } = new List<GamingImage>();
        #endregion

        public class GamingImage : ProductImage
        {
            public GamingImage()
            {

            }
            public int GamingId { get; set; }

            public Gaming Gaming { get; set; }
        }
    }
}
