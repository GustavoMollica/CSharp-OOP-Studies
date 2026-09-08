using System.Globalization;

namespace TemperatureConverter.Models
{
    public class Temperature
    {
        public double Value { get; set; }
        public int TemperatureScaleInt { get; set; }

        public override string ToString()
        {
            return $"{Value.ToString(CultureInfo.InvariantCulture)}{(TemperatureScaleInt == 1 ? "°F" : "°C")}";
        }
    }
}
