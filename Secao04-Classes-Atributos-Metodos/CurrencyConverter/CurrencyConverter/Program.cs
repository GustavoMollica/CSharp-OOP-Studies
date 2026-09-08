using CurrencyConverter.Utils;
using System.Globalization;

Console.WriteLine("Ola!\n" +
    "Informe a cotacao do dolar:");
decimal exchangeRate;
while (!decimal.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out exchangeRate))
{
    Console.WriteLine("Valor invalido. Digite novamente:");
}

Console.WriteLine("Quantos dolares voce vai comprar?");
decimal dollarsToBuy;
while (!decimal.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out dollarsToBuy))
{
    Console.WriteLine("Valor invalido. Digite novamente:");
}

var amountToPayInBrl = CurrencyConverterHelper.CalculateAmountInBrl(exchangeRate, dollarsToBuy);
Console.WriteLine($"O valor a ser pago em reais eh {amountToPayInBrl.ToString("F2", CultureInfo.InvariantCulture)} reais");