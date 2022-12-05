using System;

namespace GarysCustomGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The {this.GetType().Name} turns {direction}.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"The {this.GetType().Name} slows to a stop.");
        }
    }
}