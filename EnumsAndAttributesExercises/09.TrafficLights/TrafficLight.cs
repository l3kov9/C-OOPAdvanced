using System;

namespace _09.TrafficLights
{
    public class TrafficLight
    {
        public Light light;

        public TrafficLight(string light)
        {
            this.light = (Light)Enum.Parse(typeof(Light), light);
        }


        public void ChangeLight()
        {
            this.light++;
            this.light = (Light)((int)this.light % Enum.GetValues(typeof(Light)).Length);
        }
    }
}
