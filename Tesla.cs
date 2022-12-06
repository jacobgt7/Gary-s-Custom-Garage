using System;

namespace GarysCustomGarage
{
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past.  Wooosh!");
        }
    }
}