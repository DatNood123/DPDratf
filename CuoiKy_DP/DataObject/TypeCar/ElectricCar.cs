using CuoiKy_DP.DataObject.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.TypeCar
{
    internal class ElectricCar: Car, Refillable
    {
        public float maxCapacity;
        public float batteryCapacity;
        
        public ElectricCar(Wheel wheel, Engine engine, CarColor color, string gearBox, string modelCar, float maxCapacity, float batteryCapacity)
        {
            this.wheel = wheel;
            this.engine = engine;
            this.color = color;
            this.gearBox = gearBox;
            this.modelCar = modelCar;
            this.maxCapacity = maxCapacity;
            this.batteryCapacity = batteryCapacity;
        }
        public object Clone()
        {
            ElectricCar car = (ElectricCar)this.MemberwiseClone();

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
            batteryCapacity = maxCapacity;
        }
    }
}
