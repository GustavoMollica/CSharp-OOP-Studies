🇧🇷 Português | 🇺🇸 [English](README.md)

# CSharp-OOP-Studies

Uma coleção de exercícios e projetos em C# focados em Programação Orientada a Objetos, desenvolvidos durante o curso *C# COMPLETO Programação Orientada a Objetos + Projetos* (Nélio Alves), organizados por seção de estudo.

## Sobre

Cada pasta representa uma seção do curso, contendo os exercícios práticos daquele módulo. Os projetos evoluem em complexidade e boas práticas conforme o aprendizado avança — refatorações feitas após aprender novos conceitos (ex.: enums, exceções) são documentadas nos commits e, quando relevante, no README de cada exercício.

## Seções

### [Section04 - Classes, Atributos, Métodos](./Section04-Classes-Attributes-Methods)

| Exercício | Principais conceitos |
|---|---|
| [BankAccount](./Section04-Classes-Attributes-Methods/BankAccount) | Encapsulamento, membros estáticos, repositório em memória |
| [EmployeeManagement](./Section04-Classes-Attributes-Methods/EmployeeManagement) | Métodos de instância, constantes de domínio, cálculo de horas extras |
| [SalaryAdjustment](./Section04-Classes-Attributes-Methods/SalaryAdjustment) | Regras de negócio dentro da classe de domínio, validação sem exceções |
| [TemperatureConverter](./Section04-Classes-Attributes-Methods/TemperatureConverter) | Classe utilitária estática, nomenclatura idiomática |
| [GeometryCalculator](./Section04-Classes-Attributes-Methods/GeometryCalculator) | Delegação de responsabilidade (cálculo dentro da própria classe) |
| [RectangleCalculator](./Section04-Classes-Attributes-Methods/RectangleCalculator) | Delegação de responsabilidade, cálculo geométrico |
| [CpfValidator](./Section04-Classes-Attributes-Methods/CpfValidator) | Validação de formato com Regex, classe utilitária estática |
| [UserManagement](./Section04-Classes-Attributes-Methods/UserManagement) | Membros estáticos compartilhados entre instâncias |
| [GradeManagement](./Section04-Classes-Attributes-Methods/GradeManagement) | Encapsulamento de validação, métodos que retornam erros |
| [CurrencyConverter](./Section04-Classes-Attributes-Methods/CurrencyConverter) | Classe utilitária estática, composição de cálculos |

### [Section05 - Construtores, Sobrecarga, This, Propriedades](./Section05-Constructors-Overloading-This-Properties)

| Exercício | Principais conceitos |
|---|---|
| [RPGCharacter](./Section05-Constructors-Overloading-This-Properties/RPGCharacter) | Construtores, propriedades com `private set`, propriedades calculadas, encapsulamento |
| [BankAccountWithFee](./Section05-Constructors-Overloading-This-Properties/BankAccountWithFee) | Sobrecarga de construtores, encadeamento de construtores com `this`, constantes de domínio, validação dentro da classe de domínio |

## Tecnologias

- C# / .NET 10
- Aplicações Console

## Como executar qualquer projeto

```bash
cd <PastaDaSeção>/<NomeDoProjeto>
dotnet run
```
