using SalaryAdjustment.Models;
using System.Globalization;

var employee = new Employee();

Console.WriteLine("Digite os dados do funcionario:");
Console.WriteLine("Nome:");
employee.Name = Console.ReadLine();

Console.WriteLine("Salario bruto:");
decimal grossSalary;
while (!decimal.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out grossSalary))
{
    Console.WriteLine("Valor invalido. Digite novamente:");
}
employee.GrossSalary = grossSalary;

Console.WriteLine("Imposto:");
decimal tax;
while (!decimal.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out tax))
{
    Console.WriteLine("Valor invalido. Digite novamente:");
}
employee.Tax = tax;

Console.WriteLine($"Funcionario: {employee}");

Console.WriteLine("Digite a porcentagem para aumentar o salario do funcionario:");
decimal percentageIncrease;
while (!decimal.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out percentageIncrease))
{
    Console.WriteLine("Valor invalido. Digite novamente:");
}

var erro = employee.IncreaseSalary(percentageIncrease);
if (!string.IsNullOrEmpty(erro))
    Console.WriteLine(erro);
else
    Console.WriteLine($"Dados atualizados: {employee}");