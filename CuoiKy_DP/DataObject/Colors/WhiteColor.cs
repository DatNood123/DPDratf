using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Colors
{
    internal class WhiteColor : CarColor, ICloneable
    {
        public WhiteColor()
        {
            this.hexCode = "#FFFFFF";
            this.colorName = "White";
        }
    }
}
