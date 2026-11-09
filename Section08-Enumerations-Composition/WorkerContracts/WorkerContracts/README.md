🇺🇸 English | 🇧🇷 [Português](README.pt-br.md)

# Worker Contracts

A simple console application built in C# to practice enumerations and composition: modeling objects made of other objects and representing a fixed set of options with an `enum`.

## Overview

This exercise models a worker who belongs to a department, has a level and a base salary, and can have several hourly contracts. The user registers the department, the worker data and the contracts, then informs a month and year. The application calculates the worker's income for that month: the base salary plus the value of the contracts from that period.

## Features

- Composition: a `Worker` has a `Department` and a list of `Contract`
- `WorkerLevel` enum with explicit values (`Junior`, `MidLevel`, `Senior`), parsed case-insensitively and validated with `Enum.IsDefined`
- Contracts stored in a `private readonly` list and exposed as `IReadOnlyList<Contract>`, so they can only be changed through `AddContract` and `RemoveContract`
- Each `Contract` calculates its own total (`TotalValue`), and `Worker.Income` delegates to it
- Contracts filtered by month and year using `Date.Year` and `Date.Month`
- `required` properties for the worker name, the department and the department name
- Dates parsed with `TryParseExact` and fixed formats (`dd/MM/yyyy` and `MM/yyyy`), independent of the machine culture
- Decimal values parsed with a fixed `pt-BR` culture, accepting only the decimal separator
- Input validation using `TryParse` + retry loops with field-specific error messages, avoiding unhandled exceptions on invalid console input
- Income displayed as `pt-BR` currency

## Technologies

- C# / .NET 10
- Console Application

## Business Rules

- The income for a month is the base salary plus the total of the contracts from that month
- The total of a contract is its hours multiplied by its value per hour
- If there are no contracts in the month, the income is the base salary
- Department and worker names cannot be empty
- The level must be `Junior`, `MidLevel` or `Senior`
- The base salary and the number of contracts cannot be negative
- The value per hour and the hours of a contract must be greater than zero
- Contract dates use the `DD/MM/AAAA` format and the reference month uses `MM/AAAA`
- Decimal values use a comma as the separator (e.g. `1500,50`)

## Example

```
Entre com o nome do departamento
TI
Entre com os dados do colaborador
Digite o nome do colaborador
Alex
Digite o nivel colaborador (Junior/MidLevel/Senior):
pleno
Valor invalido. Digite uma das opcoes: Junior, MidLevel ou Senior.
midlevel
Informe a base salarial (ex: 1500,50):
1200,00
Quantos contratos para este trabalhador?
3
Entre com os dados do 1° contrato:
Data do contrato (DD/MM/AAAA):
20/08/2026
Valor por hora do contrato (ex: 50,00):
50,00
Duração do contrato (horas):
20
Entre com os dados do 2° contrato:
Data do contrato (DD/MM/AAAA):
13/06/2026
Valor por hora do contrato (ex: 50,00):
30,00
Duração do contrato (horas):
18
Entre com os dados do 3° contrato:
Data do contrato (DD/MM/AAAA):
25/08/2026
Valor por hora do contrato (ex: 50,00):
80,00
Duração do contrato (horas):
10
Digite o mês e o ano para calcular a renda (MM/AAAA):
08/2026
Nome: Alex
Departamento: TI
Renda de 08/2026: R$ 3.000,00
```

## Project Structure

```
WorkerContracts/
├── Program.cs
└── Entities/
    ├── Contract.cs
    ├── Department.cs
    ├── Worker.cs
    └── Enums/
        └── WorkerLevel.cs
```

## How to Run

```bash
dotnet run
```

## Author

Gustavo Mollica
