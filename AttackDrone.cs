using System;
using System.Collections.Generic;
using System.Text;

namespace DroneInheritance
{
    public class AttackDrone : Drone
    {
        public double WarheadWeight { get; set; }
        public string TargetType { get; set; }

        public AttackDrone(string model, string manufacturer, double maxSpeed, double flightRange,
            double maxFlightTime, double takeoffWeight, double warheadWeight, string targetType) :
            base(model, manufacturer, maxSpeed, flightRange, maxFlightTime, takeoffWeight)
        {
            WarheadWeight = warheadWeight;
            TargetType = targetType;
        }

        public void PerformStrike()
        {
            Console.WriteLine($"{Model} наносит удар по цели типа \"{TargetType}\". Масса боевой части: {WarheadWeight} кг.");
        }
    }
}
