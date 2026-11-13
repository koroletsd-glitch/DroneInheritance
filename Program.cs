using DroneInheritance;
using System;

namespace DroneInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ReconDrone forpost = new ReconDrone("Форпост-P", "УЗГА", 200, 250, 18, 500, 60, 6000);
            AttackDrone lancet = new AttackDrone("Ланцет-3", "ZALA", 110, 100, 1, 12, 5, "бронетехника");

            Console.WriteLine("=== Унаследованный метод GetInfo() ===\n");

            Drone[] drones = {forpost, lancet};

            foreach (Drone d in drones)
            {
                Console.WriteLine(d.GetInfo());
            }

            Console.WriteLine("\n=== Собственные методы ===\n");
            forpost.PerformReconnaissance();
            lancet.PerformStrike();

        }
    }
}
