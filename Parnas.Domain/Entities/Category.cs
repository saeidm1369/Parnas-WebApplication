using Parnas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class Category
    {
        public Category()
        {
        }
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public Category ParentCategory { get; set; }

        public ICollection<Category>? SubCategories { get; set; }

        #region Relations
        public ICollection<Accessories> Accessories { get; set; }
        public ICollection<Case> Cases { get; set; }
        public ICollection<CPU> CPUs { get; set; }
        public ICollection<Cooling> Coolings { get; set; }
        public ICollection<ComputerMonitor> ComputerMonitors { get; set; }
        public ICollection<FanCase> FanCases { get; set; }
        public ICollection<Gaming> Gamings { get; set; }
        public ICollection<GraphicCard> GraphicCards { get; set; }
        public ICollection<HDD> HDDs { get; set; }
        public ICollection<MotherBoard> MotherBoards { get; set; }
        public ICollection<Power> Powers { get; set; }
        public ICollection<Ram> Rams { get; set; }
        public ICollection<Rendering> Renderings { get; set; }
        public ICollection<SSD> SSDs { get; set; }
        #endregion
    }
}
