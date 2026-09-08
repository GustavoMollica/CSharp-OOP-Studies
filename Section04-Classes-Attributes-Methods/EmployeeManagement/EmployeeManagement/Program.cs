using EmployeeManagement.Models;

var employees = new List<Employee>();
int employeeCount;
Console.WriteLine("\nDigite quantos funcionarios serao cadastrados:");
while (!int.TryParse(Console.ReadLine(), out employeeCount))
{
    Console.WriteLine("Valor inserido invalido. Digite novamente:");    
}

for (int i = 0; i < employeeCount; i++)
{
    var employee = new Employee();
    var numberEmployee = i + 1;
    decimal baseSalary, overtimeHours;

    Console.WriteLine($"Digite o nome do funcionario {numberEmployee}:");
    employee.Name = Console.ReadLine();

    Console.WriteLine($"Digite o salario base do funcionario {numberEmployee}:");
    while (!decimal.TryParse(Console.ReadLine(), out baseSalary))
    {
        Console.WriteLine("Valor inserido invalido. Digite novamente:");        
    }
    employee.BaseSalary = baseSalary;

    Console.WriteLine($"Digite as horas extras do funcionario {numberEmployee} esse mes:");
    while (!decimal.TryParse(Console.ReadLine(), out overtimeHours))
    {
        Console.WriteLine("Valor inserido invalido. Digite novamente:");        
    }
    employee.OvertimeHours = overtimeHours;

    employee.CalculateTotalSalary();

    employees.Add(employee);

    Console.WriteLine("Funcionario cadastrado com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
}

Console.WriteLine($"Dados dos funcionarios cadastrados com sucesso:\n");
foreach (var employee in employees)
{
    Console.WriteLine($"{employee}");
}
