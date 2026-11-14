🇺🇸 English | 🇧🇷 [Português](README.pt-br.md)

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

### [Section05 - Constructors, Overloading, This, Properties](./Section05-Constructors-Overloading-This-Properties)

| Exercise | Main concepts |
|---|---|
| [RPGCharacter](./Section05-Constructors-Overloading-This-Properties/RPGCharacter) | Constructors, properties with `private set`, calculated properties, encapsulation |
| [BankAccountWithFee](./Section05-Constructors-Overloading-This-Properties/BankAccountWithFee) | Constructor overloading, `this` constructor chaining, domain constants, validation inside the domain class |

### [Section06 - Memory Behavior, Arrays, Lists](./Section06-Memory-Behavior-Arrays-Lists)

| Exercise | Main concepts |
|---|---|
| [DormRoomRental](./Section06-Memory-Behavior-Arrays-Lists/DormRoomRental) | Arrays, fixed-size collections, room number to index conversion, array encapsulated inside a domain class |

### Section07 - Special Topics in C# (Part 1)

This section had no practical exercises. It covered language features and types used in the following sections: type inference with `var`, `switch-case`, the ternary conditional operator, string functions, `DateTime` and `TimeSpan` (properties and operations), and `DateTimeKind` with the ISO 8601 standard.

### [Section08 - Enumerations, Composition](./Section08-Enumerations-Composition)

| Exercise | Main concepts |
|---|---|
| [WorkerContracts](./Section08-Enumerations-Composition/WorkerContracts) | Enums, composition ("has-a"), read-only collection exposure, responsibility delegation, culture-independent input parsing |
| [BlogPosts](./Section08-Enumerations-Composition/BlogPosts) | Composition with a list of objects, `StringBuilder`, value generated once in an auto-property initializer, fixed date formatting |
| [OrderManagement](./Section08-Enumerations-Composition/OrderManagement) | Enums parsed by name only, multi-level composition (order, items, product, client), price snapshot per item, totals delegated to items, `StringBuilder` summary |

## Technologies

- C# / .NET 10
- Console Applications

## How to run any project

```bash
cd <SectionFolder>/<ProjectName>/<ProjectName>
dotnet run
```

## Notes

- **Refactoring:** earlier exercises are revisited and refactored as new concepts are learned in later sections (e.g. applying constructors, properties, enums, or exceptions to a Section 4 exercise). Because of that, a project may not reflect the most recent practices of the course at the time it was first written; the commit history shows how each one evolved.
- **External exercises:** besides the course exercises, some projects come from outside the course. They were chosen to practice the concepts of that section at that moment.
