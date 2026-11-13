using System;
using System.Collections.Generic;
using System.Text;

namespace DroneInheritance
{
    public class TransportDrone : Drone
    {
        public double CargoCapacity { get; set; }
        public string CargoType { get; set; }

        public TransportDrone(string model, string manufacturer, double maxSpeed, double flightRange,
            double maxFlightTime, double takeoffWeight, double cargoCapacity, string cargoType) :
            base(model, manufacturer, maxSpeed, flightRange, maxFlightTime, takeoffWeight)
        {
            CargoCapacity = cargoCapacity;
            CargoType = cargoType;
        }

        public void Dlivercargo()
        {
            Console.WriteLine($"{Model} доставляет груз типа \"{CargoType}\" массой до {CargoCapacity} кг.");
        }
    }
}
