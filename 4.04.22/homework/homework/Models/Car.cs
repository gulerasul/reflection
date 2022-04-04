using homework.Interfeys;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Models
{
    class Car : Vehicle, IEngine, ITransmission,IWheel
    {
        public int DoorCount { get; set; }
        public string WinCode { get; set; }
        public override double DriveTime { get ; set; }
        public override double DrivePath { get; set ; }
        public int HorsePower { get; set ; }
        public int TankSize { get; set ; }
        public double CurrentOil { get ; set ; }
        public int FuelType { get; set ; }
        public int TransmissionKind { get; set; }
        public double WheelThickness { get; set; }

        public void RemainOilAmount()
        {

        }
    }
}
