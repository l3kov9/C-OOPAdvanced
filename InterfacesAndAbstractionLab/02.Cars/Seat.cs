using System;

namespace _02.Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; }

        public string Color { get; }

        public string Start()
        {
            return "Engine starts";
        }

        public string Stop()
        {
            return "Breaaaak";
        }

        public override string ToString()
        {
            return $"{this.Color} {GetType().Name} {this.Model}{Environment.NewLine}{this.Start()}{Environment.NewLine}{this.Stop()}";

        }
    }
}
