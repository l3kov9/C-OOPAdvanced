using System;

namespace InterfaceDemo.Cars
{
    public class Audi : ICar
    {
        public Audi(string model)
        {
            this.Model = model;
        }

        public string Model { get; set; }

        public void Start()
        {
            Console.WriteLine("Audi Brum!");
        }

        public void Stop()
        {
            Console.WriteLine("Audi stopped brumming");
        }
    }
}
