using System;
using System.Collections.Generic;
using AbstractionDemo.Animals;

namespace AbstractionDemo
{
    public class Startup
    {
        public static void Main()
        {
            var animals=new List<Animal>{new Bunny(),new Cat(),new Dog()};

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.SayHello());
                Console.WriteLine(Animal.NumberOfEyes);
                Console.WriteLine(animal.NumberOfLegs);
            }
        }
    }
}
