namespace InterfaceDemo.Cars
{
    public interface ICar
    {
        string Model { get; set; }

        void Start();

        void Stop();
    }
}
