using System;

namespace GarysCustomGarage
{
    public class Ram : Vehicle, IGas  // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past.  Brumbrumbrumbrum!");
        }
    }
}