using Parnas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class Accessories : BaseEntity<string>
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
        public ICollection<ProductImage> ProductImages { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
