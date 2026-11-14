using System.Globalization;

namespace OrderManagement.Entities;

public class Client
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public DateOnly BirthDate { get; set; }

    public override string ToString()
    {
        return $"{Name} ({BirthDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}) - {Email}";
    }
}
