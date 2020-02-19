using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            string temperature;

            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            Cooler cooler = new Cooler(80);

            Action<float> delegate1;
            Action<float> delegate2;
            Action<float> delegate3;

            delegate1 = heater.OnTemperatureChanged;
            delegate2 = cooler.OnTemperatureChanged;

            Console.WriteLine("Combine delegates using + operator:");
            delegate3 = delegate1 + delegate2;
            delegate3(60);

            Console.WriteLine("UnCombine delegates using - operator:");
            delegate3 = delegate3 - delegate2;
            delegate3(60);

       
           
        }
    }
}
