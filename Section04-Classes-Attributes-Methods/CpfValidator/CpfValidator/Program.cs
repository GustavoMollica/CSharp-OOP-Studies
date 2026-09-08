using CpfValidator.Models;
using CpfValidator.Utils;

var person = new Person();
var personRegistration = new List<Person>();
int age;
double height;

Console.WriteLine("Faça seu cadastro:");
Console.WriteLine("Digite seu nome:");
person.FullName = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
while(!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Valor invalido. Digite sua idade corretamente:");
}
person.Age = age;

Console.WriteLine("Digite seu cpf:");
person.Cpf = Console.ReadLine();

Console.WriteLine("Digite sua altura:");
while (!double.TryParse(Console.ReadLine(), out height))
{
    Console.WriteLine("Valor invalido. Digite sua altura corretamente:");
}
person.Height = height;

Console.WriteLine("Digite seu endereco:");
person.Address = Console.ReadLine();

if (ValidatorCpfUtils.IsCpfValid(person.Cpf))
{
    //lista simulando um banco
    personRegistration.Add(person);
    Console.WriteLine("Cadastro efetuado com sucesso\n" +
        $"{person}");
    Console.ReadKey();
}
else
    Console.WriteLine("Cpf invalido, faça o cadastro novamente.");


