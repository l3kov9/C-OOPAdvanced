using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TrafficLights
{
    public class Startup
    {
        public static void Main()
        {
            var currentTraffic = Console.ReadLine().Split();
            var trafficLights = new List<TrafficLight>();

            foreach (var light in currentTraffic)
            {
                trafficLights.Add(new TrafficLight(light));
            }

            var numberOfTraffics = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTraffics; i++)
            {
                foreach (var light in trafficLights)
                {
                    light.ChangeLight();
                    Console.Write(light.light+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
