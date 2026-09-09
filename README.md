🇺🇸 [English](./README.md) | 🇧🇷 [Português](./README.pt-BR.md)

# CSharp-OOP-Studies

A collection of C# exercises and projects focused on Object-Oriented Programming, developed while taking the course *C# COMPLETO Programação Orientada a Objetos + Projetos* (Nélio Alves), organized by study section.

## About

Each folder represents a course section, containing the practical exercises from that module. Projects evolve in complexity and best practices as learning progresses — refactors made after learning new concepts (e.g. enums, exceptions) are documented in the commits and, when relevant, in each exercise's own README.

## Sections

### [Section04 - Classes, Attributes, Methods](./Section04-Classes-Attributes-Methods)

| Exercise | Main concepts |
|---|---|
| [BankAccount](./Section04-Classes-Attributes-Methods/BankAccount) | Encapsulation, static members, in-memory repository |
| [EmployeeManagement](./Section04-Classes-Attributes-Methods/EmployeeManagement) | Instance methods, domain constants, overtime calculation |
| [SalaryAdjustment](./Section04-Classes-Attributes-Methods/SalaryAdjustment) | Business rules inside the domain class, validation without exceptions |
| [TemperatureConverter](./Section04-Classes-Attributes-Methods/TemperatureConverter) | Static utility class, idiomatic naming |
| [GeometryCalculator](./Section04-Classes-Attributes-Methods/GeometryCalculator) | Responsibility delegation (calculation inside the class itself) |
| [RectangleCalculator](./Section04-Classes-Attributes-Methods/RectangleCalculator) | Responsibility delegation, geometric calculation |
| [CpfValidator](./Section04-Classes-Attributes-Methods/CpfValidator) | Format validation with Regex, static utility class |
| [UserManagement](./Section04-Classes-Attributes-Methods/UserManagement) | Static members shared across instances |
| [GradeManagement](./Section04-Classes-Attributes-Methods/GradeManagement) | Validation encapsulation, error-returning methods |
| [CurrencyConverter](./Section04-Classes-Attributes-Methods/CurrencyConverter) | Static utility class, calculation composition |

## Technologies

- C# / .NET 10
- Console Applications

## How to run any project

```bash
cd Section04-Classes-Attributes-Methods/<ProjectName>
dotnet run
```
