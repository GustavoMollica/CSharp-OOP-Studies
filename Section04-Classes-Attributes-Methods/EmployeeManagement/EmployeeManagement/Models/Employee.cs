using System.Globalization;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        private const decimal RegularMonthlyHours = 220;
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal TotalSalary { get; private set; }
        
        public void CalculateTotalSalary()
        {
            var overtimeHoursValue = OvertimeHours * (CalculateRegularHourValue() * 1.5m);
            TotalSalary = BaseSalary + overtimeHoursValue;            
        }

        public decimal CalculateRegularHourValue()
        {
            return Math.Round(BaseSalary / RegularMonthlyHours, 2);
        }

        public override string ToString()
        {
            return $"Nome: {Name}\n" +
                $"Salario total a ser recebido: {TotalSalary.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}
