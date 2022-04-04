using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Interfeys
{
    interface IEngine
    {
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public double CurrentOil { get; set; }
        public int FuelType { get; set; }
        public abstract void RemainOilAmount();
    }
}
