using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SalaryAdjustment.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal Tax { get; set; }

        public decimal GetNetSalary()
        {
            return GrossSalary - Tax;
        }

        public string IncreaseSalary(decimal percentageIncrease)
        {
            if (percentageIncrease <= 0)
                return "O percentual deve ser maior que zero.";

            GrossSalary += GrossSalary * (percentageIncrease / 100);
            return string.Empty;
        }

        //added after the course review
        public override string ToString()
        => $"{Name}, R$ {GetNetSalary().ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
