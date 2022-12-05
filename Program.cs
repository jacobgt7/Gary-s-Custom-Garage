using System;

namespace GarysCustomGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram baseModel = new Ram();

            fxs.BatteryKWh = 20;
            fxs.MainColor = "Green";
            fxs.MaximumOccupancy = 5;

            modelS.BatteryKWh = 25;
            modelS.MainColor = "White";
            modelS.MaximumOccupancy = 5;

            mx410.FuelCapacity = 50;
            mx410.MainColor = "White";
            mx410.MaximumOccupancy = 4;

            baseModel.FuelCapacity = 40;
            baseModel.MainColor = "Red";
            baseModel.MaximumOccupancy = 5;



            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            baseModel.Drive();

            fxs.Turn("south");
            modelS.Turn("north");
            mx410.Turn("southeast");
            baseModel.Turn("west");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            baseModel.Stop();
        }
    }
}
