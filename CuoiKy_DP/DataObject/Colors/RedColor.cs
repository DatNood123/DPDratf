using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Colors
{
    internal class RedColor : CarColor, ICloneable
    {
        public RedColor()
        {
            this.hexCode = "#FF0000";
            this.colorName = "Red";
        }
    }
}
