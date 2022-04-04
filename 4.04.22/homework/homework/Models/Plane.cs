using homework.Interfeys;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Models
{
    class Plane:Vehicle, IEngine, IWheel
    {
        public double  WingLength { get; set; }
        public int HorsePower { get ; set; }
        public int TankSize { get; set; }
        public double CurrentOil { get ; set ; }
        public int FuelType { get; set ; }
        public double WheelThickness { get; set; }
        public override double DriveTime { get ; set ; }
        public override double DrivePath { get ; set ; }

        public void RemainOilAmount()
        {
           
        }
    }
}
