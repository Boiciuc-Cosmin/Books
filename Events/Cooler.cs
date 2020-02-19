using System;

namespace Events
{
   public class Cooler : ITemperatureChanged
    {
        public float Temperature { get; set; }
        public Cooler(float temperature)
        {
            Temperature = temperature;
        }

        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature > Temperature)
            {
                Console.WriteLine("Cooler: ON");
            }
            else
            {
                Console.WriteLine("Cooler: OFF");
            }
        }
    }
}
