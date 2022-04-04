using System;
using System.Collections.Generic;
using System.Text;
using homework.Interfeys;


namespace homework.Models
{
    class Bicycle: Vehicle,IWheel,ITransmission

    {
        public int PedalKind { get; set; }
        public override double DriveTime { get ; set; }
        public override double DrivePath { get ; set; }
        public double WheelThickness { get; set ; }
        public int TransmissionKind { get; set; }
    }
}
