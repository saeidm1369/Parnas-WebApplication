using Parnas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Domain.Entities
{
    public class Gaming : BaseEntity<string>
    {
        public Gaming()
        {

        }
        public string CPU { get; set; }
        public string MotherBoard { get; set; }
        public string Graphic { get; set; }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public string DeepCool { get; set; }
        public string Power { get; set; }
        public string Case { get; set; }
    }
}
