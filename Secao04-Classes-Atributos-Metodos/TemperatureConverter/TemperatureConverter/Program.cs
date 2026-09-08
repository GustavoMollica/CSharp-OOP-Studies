
using System.Globalization;
using TemperatureConverter.Models;
using TemperatureConverter.Utils;

var temp = new Temperature();
int tempEscaleInt;
double value;

Console.WriteLine("Digite a escala da temperatura a ser inserida:\n" +
    "1 - Fahrenheit\n" +
    "2 - Celsius");
while (!int.TryParse(Console.ReadLine(), out tempEscaleInt) || tempEscaleInt < 1 || tempEscaleInt > 2)
{
    Console.WriteLine("Valor inserido invalido. Digite novamente o valor corretamente:");
}
temp.TemperatureScaleInt = tempEscaleInt;

Console.WriteLine($"Digite o valor da temperatura em {(temp.TemperatureScaleInt == 1 ? "Fahrenheit" : "Celsius")}");
while (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out value))
{
    Console.WriteLine("Valor inserido invalido. Digite novamente o valor corretamente:");
}
temp.Value = value;


Console.WriteLine("\nConversao:\n" +
    "Temperatura informada:" +
    $"{temp}");

if (tempEscaleInt == 1)
{
    Console.WriteLine("Temperatura convertida:" +
    $"{TemperatureConversionUtils.FahrenheitToCelsius(temp.Value).ToString(CultureInfo.InvariantCulture)}°C");
    
}
else if(tempEscaleInt == 2)
{
    Console.WriteLine("Temperatura convertida:" +
    $"{TemperatureConversionUtils.CelsiusToFahrenheit(temp.Value).ToString(CultureInfo.InvariantCulture)}°F");
}