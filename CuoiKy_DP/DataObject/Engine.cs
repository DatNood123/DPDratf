using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject
{
    public class Engine: ICloneable
    {
        public Engine(float horsePower, string nameEngine, string version) 
        { 
            this.horsePower = horsePower;
            this.nameEngine = nameEngine;
            this.version = version;
        }
        public float horsePower { get; private set; }
        public string nameEngine { get; private set;}
        public string version { get; private set;}

        public object Clone()
        {
            return (Engine) this.MemberwiseClone();
        }
    }
}
