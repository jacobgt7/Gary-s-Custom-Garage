using System;
using System.Collections.Generic;

namespace GarysCustomGarage
{
    public interface IElectric
    {
        double BatteryKWh { get; }
        double CurrentChargePercentage { get; }
        void ChargeBattery();
    }

    public interface IGas
    {
        double FuelCapacity { get; }
        double CurrentTankPercentage { get; }
        void RefuelTank();
    }

    public interface IStation<T>
    {
        int Capacity { get; }
        void Refuel(List<T> vehicles);
    }
}