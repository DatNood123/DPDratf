using CuoiKy_DP.DataObject.TypeCar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Produce
{
    internal class GasolineCarBuilder: CarBuilder
    {
        public string _RecommentGas;
        public float _FuelTankVolume;
        public float _MaxTankVolume;
        public static GasolineCar gCar;

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
            GasolineCar car = (GasolineCar)gCar.Clone();

            gCar.wheel = _wheel;
            gCar.engine = _engine;
            gCar.color = _color;
            gCar.modelCar = _modelCar;
            gCar.gearBox = _gearBox;
            gCar.recommentGas = _RecommentGas;
            gCar.maxTankVolume = _MaxTankVolume;
            gCar.fuleTankVolume = _FuelTankVolume;

            return car;
        }
    }
}
