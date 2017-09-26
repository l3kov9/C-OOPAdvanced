namespace InterfaceDemo.Cars
{
    public class Tesla : IElectricCar, ICar
    {
        public string Model { get; set; }
        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfBatteries { get; }
    }
}
