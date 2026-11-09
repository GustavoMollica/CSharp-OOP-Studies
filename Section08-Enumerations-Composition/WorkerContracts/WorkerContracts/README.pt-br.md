🇧🇷 Português | 🇺🇸 [English](README.md)

# Contratos de Trabalhador

Aplicação console simples em C# para praticar enumerações e composição: modelar objetos formados por outros objetos e representar um conjunto fixo de opções com um `enum`.

## Visão Geral

Este exercício modela um trabalhador que pertence a um departamento, tem um nível e um salário base, e pode ter vários contratos por hora. O usuário cadastra o departamento, os dados do trabalhador e os contratos, e depois informa um mês e ano. A aplicação calcula a renda do trabalhador naquele mês: o salário base mais o valor dos contratos do período.

## Funcionalidades

- Composição: um `Worker` tem um `Department` e uma lista de `Contract`
- Enum `WorkerLevel` com valores explícitos (`Junior`, `MidLevel`, `Senior`), convertido sem diferenciar maiúsculas e minúsculas e validado com `Enum.IsDefined`
- Contratos armazenados em uma lista `private readonly` e expostos como `IReadOnlyList<Contract>`, de modo que só podem ser alterados por `AddContract` e `RemoveContract`
- Cada `Contract` calcula o próprio total (`TotalValue`), e o `Worker.Income` delega esse cálculo a ele
- Contratos filtrados por mês e ano usando `Date.Year` e `Date.Month`
- Propriedades `required` para o nome do trabalhador, o departamento e o nome do departamento
- Datas convertidas com `TryParseExact` e formatos fixos (`dd/MM/yyyy` e `MM/yyyy`), independente da cultura da máquina
- Valores decimais convertidos com a cultura `pt-BR` fixa, aceitando apenas o separador decimal
- Validação de entrada usando `TryParse` + laços de repetição com mensagens de erro específicas de cada campo, evitando exceções não tratadas em dados inválidos vindos do console
- Renda exibida no formato de moeda `pt-BR`

## Tecnologias

- C# / .NET 10
- Aplicação Console

## Regras de Negócio

- A renda de um mês é o salário base mais o total dos contratos daquele mês
- O total de um contrato é a quantidade de horas multiplicada pelo valor por hora
- Se não houver contratos no mês, a renda é o salário base
- Os nomes do departamento e do trabalhador não podem ser vazios
- O nível deve ser `Junior`, `MidLevel` ou `Senior`
- O salário base e a quantidade de contratos não podem ser negativos
- O valor por hora e as horas de um contrato devem ser maiores que zero
- As datas dos contratos usam o formato `DD/MM/AAAA` e o mês de referência usa `MM/AAAA`
- Valores decimais usam vírgula como separador (ex: `1500,50`)

## Exemplo

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

## Estrutura do Projeto

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

## Como Executar

```bash
dotnet run
```

## Autor

Gustavo Mollica
