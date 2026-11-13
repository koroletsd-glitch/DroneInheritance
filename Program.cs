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
            TransportDrone koshchey = new TransportDrone("Кощей", "Авирон", 80, 250, 6, 500, 320, "медицинский");
            LoiteringMunition kamikaze = new LoiteringMunition("Ланцет-3", "ZALA", 110, 100, 1, 12, 5, "бронетехника", 40, "оптико-электронное");
            AttackReconDrone orion = new AttackReconDrone("Орион", "Кронштадт", 200, 250, 30, 1150, 60, 7000, "крылатая ракета", 4);

            Console.WriteLine("=== Унаследованный метод GetInfo() ===\n");

            Drone[] drones = {forpost, lancet, koshchey, kamikaze, orion};

            foreach (Drone d in drones)
            {
                Console.WriteLine(d.GetInfo());
            }

            Console.WriteLine("\n=== Собственные методы ===\n");
            forpost.PerformReconnaissance();
            lancet.PerformStrike();
            koshchey.Dlivercargo();
            kamikaze.LoiterAndStrike();
            orion.PerformReconAndStrike();

        }
    }
}
