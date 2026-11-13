using System;
using System.Collections.Generic;
using System.Text;

namespace DroneInheritance
{
    public class ReconDrone : Drone
    {
        public double CameraResolution { get; set; }
        public double ReconAltitude { get; set; }

        public ReconDrone (string model, string manufacturer, double maxSpeed, double flightRange,
            double maxFlightTime, double takeoffWeight, double cameraresolution, double reconAltitude) :
            base(model, manufacturer, maxSpeed, flightRange, maxFlightTime, takeoffWeight)
        {
            CameraResolution = cameraresolution;
            ReconAltitude = reconAltitude;
        }
        public void PerformReconnaissance()
        {
            Console.WriteLine($"{Model} ведет разведку с высоты {ReconAltitude} м. Камера: {CameraResolution} Мп.");

        }

    }
}
