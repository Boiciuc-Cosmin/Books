namespace Events
{
    public interface ITemperatureChanged
    {
        public void OnTemperatureChanged(float newTemperature);
    }
}
