using Parnas.Base;
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
        public string ImageUrl { get; set; }

        #region Case Relation
        public string CaseId { get; set; }
        public Case Case { get; set; }
        #endregion

        #region Accessories Relation
        public string AccessoryId { get; set; }
        public Accessories Accessories { get; set; }
        #endregion

        #region ComputerMonitor
        public string ComputerMonitorId { get; set; }
        public ComputerMonitor ComputerMonitor { get; set; }
        #endregion

        #region Cooling
        public string CoolingId { get; set; }
        public Cooling Cooling { get; set; }
        #endregion

        #region CPU
        public string CpuId { get; set; }
        public CPU CPU { get; set; }
        #endregion

        #region FanCase
        public string FanCaseId { get; set; }
        public FanCase FanCase { get; set; }
        #endregion

        #region Gaming
        public string GamingId { get; set; }
        public Gaming Gaming { get; set; }
        #endregion

        #region GraphicCard
        public string GraphicCardId { get; set; }
        public GraphicCard GraphicCard { get; set; }
        #endregion

        #region HDD
        public string HddId { get; set; }
        public HDD HDD { get; set; }
        #endregion

        #region MotherBoard
        public string MotherBoardId { get; set; }
        public MotherBoard MotherBoard { get; set; }
        #endregion

        #region Power
        public string PowerId { get; set; }
        public Power Power { get; set; }
        #endregion

        #region Ram
        public string RamId { get; set; }
        public Ram Ram { get; set; }
        #endregion

        #region SSD
        public string SsdId { get; set; }
        public SSD SSD { get; set; }
        #endregion
    }
}
