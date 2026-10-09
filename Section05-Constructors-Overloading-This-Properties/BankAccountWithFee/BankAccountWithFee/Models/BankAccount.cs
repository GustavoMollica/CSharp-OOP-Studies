using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountWithFee.Models
{
    public class BankAccount
    {
        private const decimal _withdrawalFee = 5m;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(int numberAccount, string accountHolderName)
        {
            Id = numberAccount;
            Name = accountHolderName;
        }

        public BankAccount(int numberAccount, string accountHolderName, decimal depositAmount) : this(numberAccount, accountHolderName)
        {
                Balance += depositAmount;
        }

        public bool Deposit(decimal depositAmount)
        {
            if (!ValidateDeposit(depositAmount))
                return false;

            Balance += depositAmount;
            return true;
        }

        public bool Withdrawal(decimal withdrawalAmount)
        {
            if (!ValidateWithdrawal(withdrawalAmount))
                return false;

            Balance -= (withdrawalAmount + _withdrawalFee);
            return true;
        }

        private bool ValidateDeposit(decimal depositAmount)
        {
            return depositAmount >= 0;
        }

        private bool ValidateWithdrawal(decimal withdrawalAmount)
        {
            return withdrawalAmount >= 0;
        }

        public override string ToString()
        {
            return $"Conta: {Id}" +
                $", Titular: {Name}" +
                $", Saldo: $ {Balance}";
        }
    }
}