using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.Gaming;
using static Parnas.Domain.Entities.Rendering;

namespace Parnas.Domain.Entities
{
    public class Rendering : BaseEntity<int>, IHasImage<RenderingImage>
    {
        public Rendering()
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
        public List<RenderingImage> ImageList { get; set; } = new List<RenderingImage>();
        #endregion

        public class RenderingImage : ProductImage
        {
            public RenderingImage()
            {

            }
            public int RenderingId { get; set; }

            public Rendering Rendering { get; set; }
        }
    }
}
