using System;
using System.Collections;
using System.Collections.Generic;

namespace _03.Ferrari
{
    public class Startup
    {
        public static void Main()
        {
            var cars = new List<ICar>
            {
                new Ferrari("Honda", "Emil Lekov"),
                new Ferrari("Spider", "Pesho"),
                new Ferrari("Mercedes", "Minka"),
                new Ferrari("BMW", "Geri"),
                new Ferrari("Spider", "Emil Lekov")
            };

            Print(cars);
        }

        private static void Print(IEnumerable<ICar> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
                
                car.PushTheGas();
                car.UseBrakes();
                Console.WriteLine();
            }
        }
    }
}
