using System.Globalization;
using WorkerContracts.Entities;
using WorkerContracts.Entities.Enums;

var brazilianCulture = new CultureInfo("pt-BR");

Console.WriteLine("Entre com o nome do departamento");
string? departmentName = Console.ReadLine();
while (string.IsNullOrWhiteSpace(departmentName))
{
    Console.WriteLine("Valor invalido. Digite um nome valido para o departamento.");
    departmentName = Console.ReadLine();
}

Console.WriteLine("Entre com os dados do colaborador");
Console.WriteLine("Digite o nome do colaborador");
string? workerName = Console.ReadLine();
while (string.IsNullOrWhiteSpace(workerName))
{
    Console.WriteLine("Valor invalido. Digite um nome valido para o colaborador.");
    workerName = Console.ReadLine();
}

WorkerLevel level;
Console.WriteLine("Digite o nivel colaborador (Junior/MidLevel/Senior):");
while (!Enum.TryParse<WorkerLevel>(Console.ReadLine(), ignoreCase: true, out level) || !Enum.IsDefined(level))
{
    Console.WriteLine("Valor invalido. Digite uma das opcoes: Junior, MidLevel ou Senior.");
}

decimal baseSalary;
Console.WriteLine("Informe a base salarial (ex: 1500,50):");
while (!decimal.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, brazilianCulture, out baseSalary) || baseSalary < 0)
{
    Console.WriteLine("Valor invalido. Digite um salario maior ou igual a zero.");
}

int contractCount;
Console.WriteLine("Quantos contratos para este trabalhador?");
while (!int.TryParse(Console.ReadLine(), out contractCount) || contractCount < 0)
{
    Console.WriteLine("Valor invalido. Digite um numero inteiro maior ou igual a zero.");
}

var worker = new Worker
{
    Department = new Department
    {
        Name = departmentName
    },
    Name = workerName,
    Level = level,
    BaseSalary = baseSalary,    
};

for (int i = 0; i < contractCount; i++)
{
    var contract = new Contract();
    DateOnly contractDate;

    Console.WriteLine($"Entre com os dados do {i+1}° contrato:");
    Console.WriteLine("Data do contrato (DD/MM/AAAA):");
    while (!DateOnly.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out contractDate))
    {
        Console.WriteLine("Data invalida. Use o formato DD/MM/AAAA.");
    }
    contract.Date = contractDate;

    decimal valuePerHour;
    Console.WriteLine("Valor por hora do contrato (ex: 50,00):");
    while (!decimal.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, brazilianCulture, out valuePerHour) || valuePerHour <= 0)
    {
        Console.WriteLine("Valor invalido. Digite um valor por hora maior que zero.");
    }
    contract.ValuePerHour = valuePerHour;

    int hours;
    Console.WriteLine("Duração do contrato (horas):");
    while (!int.TryParse(Console.ReadLine(), out hours) || hours <= 0)
    {
        Console.WriteLine("Valor invalido. Digite uma quantidade de horas maior que zero.");
    }
    contract.Hours = hours;

    worker.AddContract(contract);
}

DateOnly referenceDate;
Console.WriteLine("Digite o mês e o ano para calcular a renda (MM/AAAA):");
while (!DateOnly.TryParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out referenceDate))
{
    Console.WriteLine("Data invalida. Use o formato MM/AAAA.");
}

var income = worker.Income(referenceDate.Year, referenceDate.Month);

Console.WriteLine(worker);
Console.WriteLine($"Renda de {referenceDate:MM/yyyy}: {income.ToString("C", brazilianCulture)}");