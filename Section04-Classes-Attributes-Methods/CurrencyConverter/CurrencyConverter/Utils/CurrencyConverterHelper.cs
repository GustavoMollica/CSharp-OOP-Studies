namespace CurrencyConverter.Utils
{
    public static class CurrencyConverterHelper
    {
        private const decimal Iof = 0.06m;

        public static decimal CalculateIof(decimal dollarsToBuy)
        {
            return Iof * dollarsToBuy;
        }

        public static decimal CalculateAmountInBrl(decimal exchangeRate, decimal dollarsToBuy)
        {
            return Math.Round(exchangeRate * (dollarsToBuy + CalculateIof(dollarsToBuy)), 2);
        }
    }
}