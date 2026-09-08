using GeometryCalculator.Models;
using System.Globalization;
using System.Reflection;

var circle1 = new Circle();
var circle2 = new Circle();
double radius1, radius2;

Console.Write("Digite o raio do primeiro circulo: ");
while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out radius1))
{
    Console.Write("Valor invalido. Digite novamente: ");
}
circle1.Radius = radius1;

Console.Write("Digite o raio do segundo circulo: ");
while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out radius2))
{
    Console.Write("Valor invalido. Digite novamente: ");
}
circle2.Radius = radius2;

Console.WriteLine($"\nCirculo 1 - Area: {circle1.CalculateArea().ToString("F2", CultureInfo.InvariantCulture)}, Perimetro: {circle1.CalculatePerimeter().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Circulo 2 - Area: {circle2.CalculateArea().ToString("F2", CultureInfo.InvariantCulture)}, Perimetro: {circle2.CalculatePerimeter().ToString("F2", CultureInfo.InvariantCulture)}");

if (circle1.CalculateArea() > circle2.CalculateArea())
    Console.WriteLine("\nO circulo 1 tem a maior area.");
else if (circle2.CalculateArea() > circle1.CalculateArea())
    Console.WriteLine("\nO circulo 2 tem a maior area.");
else
    Console.WriteLine("\nOs dois circulos tem a mesma area.");