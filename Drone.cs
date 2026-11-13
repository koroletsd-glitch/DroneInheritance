using System;
using System.Collections.Generic;
using System.Text;

namespace DroneInheritance
{
    public class Drone
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double MaxSpeed { get; set; }
        public double FlightRange { get; set; }
        public double MaxFlightTime { get; set; }
        public double TakeoffWeight { get; set; }

        public Drone(string model, string manufacturer, double maxSpeed, double flightRange, double maxFlightTime, double takeoffWeight)
        {
            Model = model;
            Manufacturer = manufacturer;
            MaxSpeed = maxSpeed;
            FlightRange = flightRange;
            MaxFlightTime = maxFlightTime;
            TakeoffWeight = takeoffWeight;
        }

        public string GetInfo()
        {
            return $"{Model} ({Manufacturer}): " + $"скорость {MaxSpeed} км/ч, " + 
                $"дальность {FlightRange} км, " + 
                $"время полета {MaxFlightTime} ч, " + 
                $"взлетная масса {TakeoffWeight} кг";
        }
    }
}
