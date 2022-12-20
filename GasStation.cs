using System;
using System.Collections.Generic;

namespace GarysCustomGarage
{
    public class GasStation : IStation<IGas>
    {
        public int Capacity { get; set; }

        public void Refuel(List<IGas> vehiclesAtStation)
        {
            foreach (IGas vehicle in vehiclesAtStation)
            {
                Console.WriteLine($"The {vehicle.GetType().Name} has been refueled with {vehicle.FuelCapacity} gallons of gas");
            }
        }
    }
}