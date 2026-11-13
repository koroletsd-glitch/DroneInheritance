using System;
using System.Collections.Generic;
using System.Text;

namespace DroneInheritance
{
    public class AttackReconDrone : ReconDrone
    {
        public string WeaponType { get; set; }
        public int Hardpoints { get; set; }

        public AttackReconDrone(string model, string manufacturer, double maxSpeed, double flightRange,
            double maxFlightTime, double takeoffWeight, double cameraResolution, double reconAltitude,
            string weaponType, int hardpoints) :
            base(model, manufacturer, maxSpeed, flightRange, maxFlightTime, takeoffWeight, cameraResolution, reconAltitude)
        {
            WeaponType = weaponType;
            Hardpoints = hardpoints;
        }

        public void PerformReconAndStrike()
        {
            Console.WriteLine($"{Model} выполняет разведку с высоты {ReconAltitude} м и может нести {Hardpoints} ед. вооружения \"{WeaponType}\".");
        }

    }
}
