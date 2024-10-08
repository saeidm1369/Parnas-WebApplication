using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.ComputerMonitor;
using static Parnas.Domain.Entities.Cooling;
using static Parnas.Domain.Entities.CPU;
using static Parnas.Domain.Entities.FanCase;
using static Parnas.Domain.Entities.Gaming;
using static Parnas.Domain.Entities.GraphicCard;
using static Parnas.Domain.Entities.HDD;
using static Parnas.Domain.Entities.MotherBoard;
using static Parnas.Domain.Entities.Power;
using static Parnas.Domain.Entities.Ram;
using static Parnas.Domain.Entities.Rendering;
using static Parnas.Domain.Entities.SSD;

namespace Parnas.Domain.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string? ImageName { get; set; }
        public string? ImagePath { get; set; }

        #region Relations
        public virtual ICollection<GraphicCardImage> AccessoryImageList { get; set; } = new List<GraphicCardImage>();
        public virtual ICollection<CaseImage> CaseImageList { get; set; } = new List<CaseImage>();
        public virtual ICollection<ComputerMonitorImage> ComputerMonitorImageList { get; set; } = new List<ComputerMonitorImage>();
        public virtual ICollection<CoolingImage> CoolingImageList { get; set; } = new List<CoolingImage>();
        public virtual ICollection<CPUImage> CPUImageList { get; set; } = new List<CPUImage>();
        public virtual ICollection<FanCaseImage> FanCaseImageList { get; set; } = new List<FanCaseImage>();
        public virtual ICollection<GamingImage> GamingImageList { get; set; } = new List<GamingImage>();
        public virtual ICollection<GraphicCardImage> GraphicCardImageList { get; set; } = new List<GraphicCardImage>();
        public virtual ICollection<HDDImage> HDDImageList { get; set; } = new List<HDDImage>();
        public virtual ICollection<MotherBoardImage> MotherBoardImageList { get; set; } = new List<MotherBoardImage>();
        public virtual ICollection<PowerImage> PowerImageList { get; set; } = new List<PowerImage>();
        public virtual ICollection<RamImage> RamImageList { get; set; } = new List<RamImage>();
        public virtual ICollection<RenderingImage> RenderingImageList { get; set; } = new List<RenderingImage>();
        public virtual ICollection<SSDImage> SSDImageList { get; set; } = new List<SSDImage>();
        #endregion
    }
}
