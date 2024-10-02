using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.FanCase;

namespace Parnas.Domain.Entities
{
    public class FanCase : BaseEntity<int>, IHasImage<FanCaseImage>
    {
        public FanCase()
        {
            
        }
        public string? FanCaseType { get; set; }
        public string? FanCaseUsageType { get; set; }
        public bool FanCaseController { get; set; }
        public bool CaseFanSpeedController { get; set; }
        public string? CaseFanNoiseLevel { get; set; }
        public string? RatiotionSpeedOfTheCaseFan { get; set; }
        public string? FanCaseLighting { get; set; }
        public string? MaximumCaseAirFlow { get; set; }
        public bool LightingControllerFanCase { get; set; }

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        // IHasImage Properties
        public List<FanCaseImage> ImageList { get; set; } = new List<FanCaseImage>();
        #endregion
        public class FanCaseImage : ProductImage
        {
            public FanCaseImage()
            {

            }
            public int FanCaseId { get; set; }

            public FanCase FanCase { get; set; }
        }
    }
}
