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

### [Section06 - Comportamento de Memória, Arrays, Listas](./Section06-Memory-Behavior-Arrays-Lists)

| Exercício | Principais conceitos |
|---|---|
| [DormRoomRental](./Section06-Memory-Behavior-Arrays-Lists/DormRoomRental) | Arrays, coleções de tamanho fixo, conversão de número do quarto para índice, array encapsulado dentro da classe de domínio |

### Section07 - Tópicos Especiais em C# (Parte 1)

Esta seção não teve exercícios práticos. Ela abordou recursos da linguagem e tipos usados nas seções seguintes: inferência de tipos com `var`, `switch-case`, operador condicional ternário, funções para string, `DateTime` e `TimeSpan` (propriedades e operações), e `DateTimeKind` com o padrão ISO 8601.

### [Section08 - Enumerações, Composição](./Section08-Enumerations-Composition)

| Exercício | Principais conceitos |
|---|---|
| [WorkerContracts](./Section08-Enumerations-Composition/WorkerContracts) | Enums, composição ("tem-um"), exposição de coleção somente leitura, delegação de responsabilidade, conversão de entrada independente da cultura da máquina |
| [BlogPosts](./Section08-Enumerations-Composition/BlogPosts) | Composição com lista de objetos, `StringBuilder`, valor gerado uma única vez em inicializador de auto-property, formatação de data fixa |
| [OrderManagement](./Section08-Enumerations-Composition/OrderManagement) | Enum aceito apenas pelo nome, composição em vários níveis (pedido, itens, produto, cliente), preço do item guardado no momento da compra, totais delegados aos itens, resumo com `StringBuilder` |

## Tecnologias

- C# / .NET 10
- Aplicações Console

## Como executar qualquer projeto

```bash
cd <PastaDaSeção>/<NomeDoProjeto>/<NomeDoProjeto>
dotnet run
```

## Observações

- **Refatoração:** exercícios anteriores são revisitados e refatorados conforme novos conceitos são aprendidos nas seções seguintes (ex.: aplicar construtores, propriedades, enums ou exceções em um exercício da Seção 4). Por isso, um projeto pode não refletir as práticas mais recentes do curso no momento em que foi escrito; o histórico de commits mostra como cada um evoluiu.
- **Exercícios externos:** além dos exercícios do curso, alguns projetos vêm de fora dele. Foram escolhidos para praticar os conceitos daquela seção naquele momento.
