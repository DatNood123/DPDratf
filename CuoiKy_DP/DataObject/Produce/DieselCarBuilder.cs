using CuoiKy_DP.DataObject.TypeCar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Produce
{
    internal class DieselCarBuilder: CarBuilder
    {
        public string _RecommentGas;
        public float _FuelTankVolume;
        public float _MaxTankVolume;
        public static DieselCar dCar;

        public void setRecommentGas(string recommentGas)
        {
            _RecommentGas = recommentGas;
        }
        public void setFuelTankeVolume(float fuelTankeVolume)
        {
            _FuelTankVolume = fuelTankeVolume;
        }
        public void setMaxTankVolume(float maxTankVolume)
        {
            _MaxTankVolume = maxTankVolume;
        }
        public override Car BuildCar()
        {
            DieselCar car = (DieselCar)dCar.Clone();

            dCar.wheel = _wheel;
            dCar.engine = _engine;
            dCar.color = _color;
            dCar.modelCar = _modelCar;
            dCar.gearBox = _gearBox;
            dCar.recommentGas = _RecommentGas;
            dCar.maxTankVolume = _MaxTankVolume;
            dCar.fuleTankVolume = _FuelTankVolume;

            return car;
        }
    }
}
