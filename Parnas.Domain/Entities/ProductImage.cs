using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string? ImageName { get; set; }
        public string? ImagePath { get; set; }

        #region Relations
        public virtual ICollection<AccessoryImage> ImageList { get; set; } = new List<AccessoryImage>();
        #endregion
    }
}
