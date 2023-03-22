using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Colors
{
    internal class GreenColor: CarColor, ICloneable
    {
        public GreenColor()
        {
            this.hexCode = "#00FF00";
            this.colorName = "Green";
        }
    }
}
