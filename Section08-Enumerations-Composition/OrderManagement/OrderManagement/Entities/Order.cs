using System.Globalization;
using System.Text;
using OrderManagement.Entities.Enums;

namespace OrderManagement.Entities;

public class Order
{
    private readonly List<OrderItem> _items = new();
    public DateTime Moment { get; private set; } = DateTime.Now;
    public OrderStatus Status { get; set; }
    public required Client Client { get; set; }
    public IReadOnlyList<OrderItem> Items => _items;

    public void AddItem(OrderItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        _items.Remove(item);
    }

    public decimal Total()
    {
        return _items.Sum(item => item.Subtotal());
    }

    public override string ToString()
    {
        var brazilianCulture = CultureInfo.GetCultureInfo("pt-BR");
        var sb = new StringBuilder();
        sb.AppendLine($"Momento do pedido: {Moment.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Status do pedido: {Status}");
        sb.AppendLine($"Cliente: {Client}");
        sb.AppendLine("Itens do pedido:");
        foreach (var item in _items)
        {
            sb.AppendLine(item.ToString());
        }
        sb.Append($"Preco total: {Total().ToString("C", brazilianCulture)}");
        return sb.ToString();
    }
}
