using System;

namespace GarysCustomGarage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past. Zoooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}