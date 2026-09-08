using Microsoft.VisualBasic.FileIO;
using UserManagement.Models;

var users = new List<User>();
var next = true;
int option;

do
{
    Console.WriteLine("\n1 - Cadastrar usuario\n" +
        "2 - Ver total de usuarios ja criados\n" +
        "0 - Sair\n");

    while (!int.TryParse(Console.ReadLine(), out option) || option < 0 || option > 2)
    {
        Console.WriteLine("Opcao invalida. Digite novamente:");
    }    

    switch (option)
    {
        case 1:
            {
                var user = new User();

                Console.Write("Digite o nome do usuario: ");
                user.Name = Console.ReadLine();

                Console.Write("Digite o email do usuario: ");
                user.Email = Console.ReadLine();

                users.Add(user);

                Console.WriteLine($"Usuario cadastrado com sucesso:\n{user}");
                break;
            }
        case 2:
            {
                Console.WriteLine($"Total de usuarios ja criados: {User.TotalUserCount}");
                break;
            }
        case 0:
            {
                next = false;
                break;
            }
    }

    if (next)
    {
        Console.ReadKey();
        Console.Clear();
    }
}
while (next);