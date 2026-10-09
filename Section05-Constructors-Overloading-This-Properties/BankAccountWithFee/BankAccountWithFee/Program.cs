using BankAccountWithFee.Models;

Console.WriteLine("Digite o número da conta:");
int numberAccount;
while (!int.TryParse(Console.ReadLine(), out numberAccount))
{
    Console.WriteLine("Número de conta inválido. Digite novamente:");
}

Console.WriteLine("Digite o titular da conta:");
var name = Console.ReadLine();

string initialDeposit;
while (true)
{
    Console.WriteLine("Havera deposito inicial? (s/n)");
    initialDeposit = Console.ReadLine();

    if (initialDeposit == "s" || initialDeposit == "n")
        break;

    Console.WriteLine("Opção inválida. Digite apenas 's' ou 'n'.");
}

BankAccount bankAccount;

if (initialDeposit == "s")
{
    decimal initialDepositAmount;
    while (true)
    {
        Console.WriteLine("Digite o valor do deposito inicial:");

        if (!decimal.TryParse(Console.ReadLine(), out initialDepositAmount))
        {
            Console.WriteLine("Valor inválido. Digite um número.");
            continue;
        }

        if (initialDepositAmount < 0)
        {
            Console.WriteLine("O valor não pode ser negativo. Digite novamente.");
            continue;
        }

        break;
    }

    bankAccount = new BankAccount(numberAccount, name, initialDepositAmount);
}
else
{
    bankAccount = new BankAccount(numberAccount, name);
}

Console.WriteLine("\nConta cadastrada com sucesso:");
Console.WriteLine($"{bankAccount}");

decimal depositAmount;
while (true)
{
    Console.WriteLine("\nEntre com um valor para deposito:");

    if (!decimal.TryParse(Console.ReadLine(), out depositAmount))
    {
        Console.WriteLine("Valor inválido. Digite um número.");
        continue;
    }

    if (!bankAccount.Deposit(depositAmount))
    {
        Console.WriteLine("Depósito não permitido (valor negativo). Tente novamente.");
        continue;
    }

    break;
}

Console.WriteLine("\nDados da conta atualizados com sucesso:");
Console.WriteLine($"{bankAccount}");

decimal withdrawalAmount;
while (true)
{
    Console.WriteLine("\nEntre com um valor para saque:");

    if (!decimal.TryParse(Console.ReadLine(), out withdrawalAmount))
    {
        Console.WriteLine("Valor inválido. Digite um número.");
        continue;
    }

    if (!bankAccount.Withdrawal(withdrawalAmount))
    {
        Console.WriteLine("Valor de saque inválido (não pode ser negativo). Tente novamente.");
        continue;
    }

    break;
}

Console.WriteLine("\nDados da conta atualizados com sucesso:");
Console.WriteLine($"{bankAccount}");