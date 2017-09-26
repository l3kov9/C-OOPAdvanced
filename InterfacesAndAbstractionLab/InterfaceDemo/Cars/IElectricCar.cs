namespace InterfaceDemo.Cars
{
    public interface IElectricCar : ICar
    {
        int NumberOfBatteries { get; }
    }
}
