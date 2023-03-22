using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Colors
{
    internal class BlackColor: CarColor, ICloneable
    {
        public BlackColor()
        {
            this.hexCode = "#000000";
            this.colorName = "Black";
        }
    }
}
