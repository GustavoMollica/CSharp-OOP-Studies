using BankAccount.Models;
using System.Globalization;

var accounts = new List<Account>();
var next = true;
do
{
    Console.WriteLine("\nDigite a opcao que deseja:");
    Console.WriteLine("1 - Criar uma conta;\n" +
        "2- Fazer deposito;\n" +
        "3- Fazer saque;\n" +
        "0 - Sair do sistema\n");
    int option = int.Parse(Console.ReadLine());
    int numberAccount;

    switch (option)
    {        
        case 1:
            {
                var account = new Account();                

                Console.Write("Digite o nome da conta:");
                account.Name = Console.ReadLine();

                accounts.Add(account);

                Console.WriteLine($"Conta criada com sucesso:{account}\n\n" +                    
                    $"Faca seu primeiro deposito para ter saldo na sua conta\n" +
                    $"Obrigado pela preferencia");
                break;
            }
        case 2:
            {
                Console.Write("Digite o numero da conta a ser feito o deposito:");
                numberAccount = int.Parse(Console.ReadLine());

                var targetAccount = accounts.FirstOrDefault(x => x.NumberAccount == numberAccount);

                if (targetAccount == null)
                {
                    Console.WriteLine("Conta não encontrada.");
                    break;
                }

                Console.Write("Digite o valor a ser depositado:");
                targetAccount.Deposit(decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine($"Conta atualizada: {targetAccount}");
                break;
            }
        case 3:
            {
                Console.Write("Digite o numero da conta a ser feito o saque:");
                numberAccount = int.Parse(Console.ReadLine());

                var targetAccount = accounts.FirstOrDefault(x => x.NumberAccount == numberAccount);

                if (targetAccount == null)
                {
                    Console.WriteLine("Conta não encontrada.");
                    break;
                }

                Console.Write("Digite o valor a ser sacado:");
                var erro = targetAccount.Withdraw(decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                if (!string.IsNullOrEmpty(erro))
                {
                    Console.WriteLine(erro);
                    break;
                }

                Console.WriteLine($"Conta atualizada: {targetAccount}");
                break;
            }
        case 0:
            {
                next = false;
                break;
            }
        default:
            {
                Console.WriteLine("Opcao invalida");
                break;
            }
    }
    Console.ReadKey();
    Console.Clear();
}
while (next);