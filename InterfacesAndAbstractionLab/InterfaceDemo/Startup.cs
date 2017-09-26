using System;
using System.Collections.Generic;
using InterfaceDemo.Cars;

namespace InterfaceDemo
{
    public class Startup
    {
        public static void Main()
        {
            var cars = new List<ICar>();

            cars.Add(new Audi("A6"));
            cars.Add(new Mercedes("C320"));

            foreach (var car in cars)
            {
                Console.WriteLine(car.GetType().Name);
                Console.WriteLine(car.Model);
                car.Start();
                Console.WriteLine(Environment.NewLine);
            }

            IAnimall cat=new Cat("Pesho",4);
            IAnimall dog=new Dog("Gosho",6);
            Print(cat);
            Print(dog);
        }

        private static void Print(IAnimall animal)
        {
            Console.WriteLine(animal.MakeNoise());
        }
    }
}
