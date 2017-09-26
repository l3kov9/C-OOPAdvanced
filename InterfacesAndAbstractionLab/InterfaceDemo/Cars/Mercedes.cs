using System;

namespace InterfaceDemo.Cars
{
    public class Mercedes : ICar
    {
        public string Model { get; set; }

        public Mercedes(string model)
        {
            this.Model = model;
        }
        
        public void Start()
        {
            Console.WriteLine("Brum!");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Brumming!");
        }
    }
}
