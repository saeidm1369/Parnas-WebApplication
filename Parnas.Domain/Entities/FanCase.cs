using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class FanCase : BaseEntity<int> , IHasImage
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

        // IHasImage Properties
        public string? ImageName { get; set; }
        public string? ImagePath { get; set; }

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
