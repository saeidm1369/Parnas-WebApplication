using Parnas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnas.Domain.MainInterface
{
    public interface IHasImage<TEnttiy>
    {
        public List<TEnttiy> ImageList { get; set; }
    }
}
