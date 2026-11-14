using System.Globalization;
using OrderManagement.Entities;
using OrderManagement.Entities.Enums;

var brazilianCulture = new CultureInfo("pt-BR");

Console.WriteLine("Entre com os dados do cliente:");
Console.WriteLine("Digite o nome:");
string? name = Console.ReadLine();
while (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Valor invalido. Digite um nome valido.");
    name = Console.ReadLine();
}

Console.WriteLine($"Digite o email de {name}:");
string? email = Console.ReadLine();
while (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
{
    Console.WriteLine("Valor invalido. Digite um email valido (ex: nome@email.com).");
    email = Console.ReadLine();
}

DateOnly birthDate;
Console.WriteLine($"Digite a data de nascimento de {name} (DD/MM/AAAA):");
while (!DateOnly.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
{
    Console.WriteLine("Data invalida. Use o formato DD/MM/AAAA.");
}

var client = new Client
{
    Name = name,
    Email = email,
    BirthDate = birthDate
};

Console.WriteLine("Entre com os dados do pedido:");
Console.WriteLine("Digite o status (PendingPayment/Processing/Shipped/Delivered):");
string? statusInput = Console.ReadLine();
while (statusInput is null
    || !Enum.GetNames<OrderStatus>().Contains(statusInput, StringComparer.OrdinalIgnoreCase))
{
    Console.WriteLine("Valor invalido. Digite uma das opcoes: PendingPayment, Processing, Shipped ou Delivered.");
    statusInput = Console.ReadLine();
}

OrderStatus status = Enum.Parse<OrderStatus>(statusInput, ignoreCase: true);

var order = new Order
{
    Status = status,
    Client = client
};

int itemCount;
Console.WriteLine("Quantos itens para este pedido?");
while (!int.TryParse(Console.ReadLine(), out itemCount) || itemCount <= 0)
{
    Console.WriteLine("Valor invalido. Digite um numero inteiro maior que zero.");
}

for (int i = 1; i <= itemCount; i++)
{
    Console.WriteLine($"Entre com os dados do {i}° item:");

    Console.WriteLine("Nome do produto:");
    string? productName = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(productName))
    {
        Console.WriteLine("Valor invalido. Digite um nome valido para o produto.");
        productName = Console.ReadLine();
    }

    decimal productPrice;
    Console.WriteLine("Preco do produto (ex: 1000,00):");
    while (!decimal.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, brazilianCulture, out productPrice) || productPrice <= 0)
    {
        Console.WriteLine("Valor invalido. Digite um preco maior que zero.");
    }

    int quantity;
    Console.WriteLine("Quantidade:");
    while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
    {
        Console.WriteLine("Valor invalido. Digite uma quantidade maior que zero.");
    }

    var product = new Product
    {
        Name = productName,
        Price = productPrice
    };

    order.AddItem(new OrderItem
    {
        Product = product,
        Price = productPrice,
        Quantity = quantity
    });
}

Console.WriteLine();
Console.WriteLine("RESUMO DO PEDIDO:");
Console.WriteLine(order);
