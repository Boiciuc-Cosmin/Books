using System;

namespace Events
{
    public class Thermostat
    {
        public Action<float> OnTemperatureChange { get; set; }
        private float _CurrentTemperature;
        public float CurrentTemperature 
        {
            get
            {
                return _CurrentTemperature;
            }
            set
            {
                if(value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    OnTemperatureChange?.Invoke(value);

                        //It can be done like this too..
                    //Action<float> localChange = OnTemperatureChange;
                    //if(localChange != null)
                    //{
                    //    localChange(value);
                    //}
                }
            }
        }
    }
}
