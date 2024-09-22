using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.MainInterface
{
    public interface IHasImage
    {
        string ImageName { get; set; }
        string ImagePath { get; set; }
    }
}
