using Parnas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class FanCase : BaseEntity<string>
    {
        public FanCase()
        {
            
        }
        public string FanCaseType { get; set; }
        public string FanCaseUsageType { get; set; }
        public bool FanCaseController { get; set; }
        public bool CaseFanSpeedController { get; set; }
        public string CaseFanNoiseLevel { get; set; }
        public string RatiotionSpeedOfTheCaseFan { get; set; }
        public string FanCaseLighting { get; set; }
        public string MaximumCaseAirFlow { get; set; }
        public bool FanCaseLightingController { get; set; }
    }
}
