using CuoiKy_DP.DataObject.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Produce
{
    internal abstract class CarBuilder
    {
        public Wheel _wheel;
        public Engine _engine;
        public CarColor _color;
        public string _gearBox;
        public string _modelCar;

        public void setWheel(Wheel wheel) 
        {
            _wheel = wheel;
        }

        public void setEngine(Engine engine)
        {
            _engine = engine;
        }

        public void setColor(CarColor color)
        {
            _color = color;
        }
        public void setGear(string gear)
        {
            _gearBox = gear;
        }
        public void setModel(string modelCar)
        {
            _modelCar = modelCar;
        }

        public abstract Car BuildCar();
    }
}
