using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Base
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Dimensions { get; set; }
        public decimal Price { get; set; }
        public string Weight { get; set; }
        public string Type { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
