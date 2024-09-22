using Parnas.Base;
using Parnas.Domain.MainInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class MotherBoard : BaseEntity<int> , IHasImage
    {
        public MotherBoard()
        {

        }
        public string? Platform { get; set; }
        public string? Chipset { get; set; }
        public string? AppearanceOfTheMotherBoard { get; set; }
        public string? ProccesorSocket { get; set; }
        public string? SupportedProccesor { get; set; }
        public string? MotherBoardMemoryTechnology { get; set; }
        public string? MemorySlot { get; set; }
        public string? Configuration { get; set; }
        public string? MaximumMemorySize { get; set; }
        public string? XmpSupport { get; set; }
        public string? MainPowerConnector { get; set; }
        public string? CPUPowerConnector { get; set; }
        public string? PCIExperssX16Slot { get; set; }
        public string? PCIExperssX16Generation { get; set; }
        public string? M2Slot { get; set; }
        public string? NumberOfSataPort { get; set; }
        public string? RaidSupport { get; set; }
        public string? MotherBoardDisplayPortOutput { get; set; }
        public string? HdmiOutputOfTheMotherBoard { get; set; }
        public bool SoundChipset { get; set; }
        public bool Bluetooth { get; set; }
        public string? BluetoothVersion { get; set; }

        // IHasImage Properties
        public string? ImageName { get; set; }
        public string? ImagePath { get; set; }

        #region Relations
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        #endregion
    }
}
