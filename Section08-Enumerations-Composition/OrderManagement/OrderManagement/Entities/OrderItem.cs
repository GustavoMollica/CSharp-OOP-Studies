using System.Globalization;

namespace OrderManagement.Entities;

public class OrderItem
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public required Product Product { get; set; }

    public decimal Subtotal()
    {
        return Price * Quantity;
    }

    public override string ToString()
    {
        var brazilianCulture = CultureInfo.GetCultureInfo("pt-BR");
        return $"{Product.Name}, {Price.ToString("C", brazilianCulture)}, " +
            $"Quantidade: {Quantity}, " +
            $"Subtotal: {Subtotal().ToString("C", brazilianCulture)}";
    }
}
