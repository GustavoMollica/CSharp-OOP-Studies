
namespace TemperatureConverter.Utils
{
    public static class TemperatureConversionUtils
    {
        public static double CelsiusToFahrenheit(double tempC)
        {
            return Math.Round((tempC * 9.0/5) + 32, 2);
        }

        public static double FahrenheitToCelsius(double tempF)
        {
            return Math.Round((tempF - 32) * 5.0/9, 2);
        }
    }
}
