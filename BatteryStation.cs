using System;
using System.Collections.Generic;

namespace GarysCustomGarage
{
    public class BatteryStation : IStation<IElectric>
    {
        public int Capacity { get; set; }

        public void Refuel(List<IElectric> vehiclesAtStation)
        {
            foreach (IElectric vehicle in vehiclesAtStation)
            {
                Console.WriteLine($"The {vehicle.GetType().Name} has been recharged with {vehicle.BatteryKWh} KWh of power");
            }
        }
    }
}