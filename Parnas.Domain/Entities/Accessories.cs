using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class Accessories : BaseEntity<int>, IHasImage<GraphicCardImagr>
    {
        public Accessories()
        {
            
        }
        public string? Lighting { get; set; }
        public string? ConnectionPort { get; set; }
        public string? InterfaceType { get; set; }
        public string? Microphone { get; set; }
        public string? Input { get; set; }
        public string? OutPut { get; set; }
        public string? UserType { get; set; }
        public string? Quality { get; set; }
        public bool AntiGhosting { get; set; }
        public string? Sensor { get; set; }

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // IHasImage Properties
        public List<GraphicCardImagr> ImageList { get; set; } = new List<GraphicCardImagr>();
        #endregion
    }

    public class GraphicCardImagr : ProductImage
    {
        public GraphicCardImagr()
        {
            
        }
        public int AccessoryId { get; set; }

        public Accessories Accessories { get; set; }
    }
}
