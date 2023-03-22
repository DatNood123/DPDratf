using CuoiKy_DP.DataObject.TypeCar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Produce
{
    internal class ElectricCarBuilder: CarBuilder
    {
        public float _MaxBatteryCapacity;
        public float _BatteryCapacity;
        public static ElectricCar eCar;
       

        public void setBetteryCapacity(float batteryCapacity)
        {
            _BatteryCapacity = batteryCapacity;
        }

        public void setMaxBetteryCapacity(float batteryCapacity)
        {
            _MaxBatteryCapacity = batteryCapacity;
        }

        public override Car BuildCar()
        {
            ElectricCar car = (ElectricCar) eCar.Clone();

            eCar.wheel = _wheel;
            eCar.engine = _engine;
            eCar.color = _color;
            eCar.modelCar = _modelCar;
            eCar.gearBox = _gearBox;
            eCar.maxCapacity = _MaxBatteryCapacity;
            eCar.batteryCapacity = _BatteryCapacity;
          
            return car;
        }
    }
}
