using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Colors
{
    internal class BlueColor : CarColor, ICloneable
    {
        public BlueColor()
        {
            this.hexCode = "#0000FF";
            this.colorName = "Blue";
        }
    }
}
