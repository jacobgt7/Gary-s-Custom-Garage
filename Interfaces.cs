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
}