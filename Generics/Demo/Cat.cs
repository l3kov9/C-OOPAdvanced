using System;

namespace Demo
{
    public class Cat
    {
        private string name;

        private int age;

        public Cat(string name, int age)
        {

        }

        public void Eat<T>(T food)
        {
            Console.WriteLine($"Eating {food.ToString()}");
        }
    }
}
