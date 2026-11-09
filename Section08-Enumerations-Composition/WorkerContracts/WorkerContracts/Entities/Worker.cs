using WorkerContracts.Entities.Enums;

namespace WorkerContracts.Entities;

public class Worker
{
    public required string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public decimal BaseSalary { get; set; }
    private readonly List<Contract> _contracts = new();
    public IReadOnlyList<Contract> Contracts => _contracts;       
    public required Department Department { get; set; }

    public void AddContract(Contract contract)
    {
        _contracts.Add(contract);
    }

    public void RemoveContract(Contract contract) 
    {
        _contracts.Remove(contract);
    }

    public decimal Income(int year, int month)
    {
        var contractsByDate = Contracts.Where(x => x.Date.Month == month && x.Date.Year == year).ToList();

        if (!contractsByDate.Any())
            return BaseSalary;

        decimal value = BaseSalary;
        foreach (var contract in contractsByDate)
        {
            value += contract.TotalValue();
        }

        return value;
    }

    public override string ToString()
    {
        return $"Nome: {Name}\n" +
            $"Departamento: {Department.Name}";
    }

}
