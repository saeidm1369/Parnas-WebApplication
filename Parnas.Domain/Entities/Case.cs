using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class Case : BaseEntity<int>
    {
        public Case()
        {

        }
        public string? Inch3_5DriveBay {get; set;}
        public string? Inch2_5DriveBay { get; set;}
        public string? CaseLighting { get; set;}
        public string? MaxSizeOfCoolerCeilingPanel { get; set;}
        public string? MaxSizeOfCoolerFrontPanel { get; set;}
        public string? MaxSizeOfCoolerBackPanel { get; set;}
        public string? MaximumCPUCoolerHeight { get; set;}
        public string? MaximumLengthOfGraphicCard { get; set;}
        public string? NumberofPowerSuppliesThatCanBeInstalled { get; set;}
        public string? PowerSupplyInstallationLocation { get; set;}
        public string? NumberOfFansThatCanBeInstalledInCase { get; set;}
        public string? NumberOfFanInstalledInCase { get; set;}
        public string? NumberOf120mmInstallableFans { get; set;}
        public string? NumberOfInstalledFansIs140mm { get; set;}
        public string? NumberOfFansThatCanBeInstalledonTheBack { get; set;}
        public string? NumberOfFansThatCanBeInstalledInTheFront { get; set;}
        public string? NumberOfFansThatCanBeInstalledinTheCeiling { get; set;}
        public string? NumberofUSBPortsIs3Cases { get; set;}
        public string? CaseUSBType_CPort { get; set;}
        public bool CaseFanSpeedController { get; set;}
        public bool FancaseLightingController { get; set;}
        public string? Lighting { get; set;}
        public bool MicrophoneInput { get; set;}
        public bool HeadPhoneOutPut { get; set;}

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    };
}
