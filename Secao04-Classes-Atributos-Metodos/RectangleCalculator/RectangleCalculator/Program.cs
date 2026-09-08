
using RectangleCalculator.Model;
using System.Globalization;

var rectangle = new Rectangle();

Console.WriteLine("Ente com a largura e altura do retangulo:");
Console.WriteLine("Largura:");
double width;
while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out width))
{
    Console.WriteLine("Valor invalido. Digite novamente:");
}
rectangle.Width = width;

Console.WriteLine("Altura:");
double height;
while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out height))
{
    Console.WriteLine("Valor invalido. Digite novamente:");
}
rectangle.Height = height;

var area = rectangle.CalculateArea();
var perimeter = rectangle.CalculatePerimeter();
var diagonal = rectangle.CalculateDiagonal();

Console.WriteLine("Dados do retangulo:");
Console.WriteLine($"AREA {area.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"PERIMETRO {perimeter.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"DIAGONAL {diagonal.ToString("F2", CultureInfo.InvariantCulture)}");
