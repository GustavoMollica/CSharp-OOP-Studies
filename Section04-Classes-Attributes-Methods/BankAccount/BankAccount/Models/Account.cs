namespace BankAccount.Models
{
    public class Account
    {
        private static int _nextNumberAccount = 1;

        private const decimal WithdrawalFee = 5m;
        public string Name { get; set; }
        public decimal Balance { get; private set; }
        public int NumberAccount { get; private set; }

        public Account()
        {
            NumberAccount = _nextNumberAccount;
            _nextNumberAccount++;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public string Withdraw(decimal amount)
        {
            var totalWithdraw = amount + WithdrawalFee;

            if (totalWithdraw > Balance)
                return "Saque maior que o saldo da conta.";

            Balance -= totalWithdraw;
            return string.Empty;
        }

        public override string ToString()
        {
            return $"\nNumero da conta: {NumberAccount}\n" +
                $"Nome: {Name}\n" +
                $"Saldo: {Balance:F2} reais";
        }
    }
}
