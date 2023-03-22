using CuoiKy_DP.DataObject.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.TypeCar
{
    internal class GasolineCar : Car, ICloneable, Refillable
    {
        public float maxTankVolume;
        public float fuleTankVolume;
        public string recommentGas;
        public GasolineCar(Wheel wheel, Engine engine, CarColor color, string gearBox, string modelCar, float maxTankVolume, float fuleTankVolume, string recommentGas)
        {
            this.wheel = wheel;
            this.engine = engine;
            this.color = color;
            this.gearBox = gearBox;
            this.modelCar = modelCar;
            this.maxTankVolume = maxTankVolume;
            this.fuleTankVolume = fuleTankVolume;
            this.recommentGas = recommentGas;
        }
        public object Clone()
        {
            GasolineCar car = (GasolineCar)this.MemberwiseClone();
            
            Wheel wheel = (Wheel)this.wheel.Clone();
            Engine engine = (Engine)this.engine.Clone();
            CarColor carColor = (CarColor)this.color.Clone();
            car.color = carColor;
            car.wheel = wheel;
            car.engine = engine;
            
            return car;
        }

        public void refillFuel()
        {
            fuleTankVolume = maxTankVolume;
        }
    }
}
