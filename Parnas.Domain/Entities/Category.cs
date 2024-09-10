using Parnas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class Category : BaseEntity<string>
    {
        public Category()
        {

        }
        public string ParentId { get; set; }
        public Category ParentCategory { get; set; }

        public ICollection<Category> SubCategories { get; set; }
    }
}
