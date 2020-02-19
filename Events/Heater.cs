using System;

namespace Events
{
    public class Heater : ITemperatureChanged
    {
        public float Temperature { get; set; }
        public Heater(float tempertaure)
        {
            Temperature = tempertaure;
        }

        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature < Temperature)
            {
                Console.WriteLine("Heater: ON");
            }
            else
            {
                Console.WriteLine("Heater: OFF");
            }
        }
    }
}
