🇧🇷 Português | 🇺🇸 [English](README.md)

# Conta Bancária com Taxa

Aplicação console simples em C# para praticar fundamentos de programação orientada a objetos: classes, construtores, encapsulamento e validação de entrada.

## Visão Geral

Este exercício modela uma conta bancária básica que permite a criação da conta (com ou sem depósito inicial), depósitos e saques. Todo saque aplica uma taxa fixa.

## Funcionalidades

- Criar conta com ou sem depósito inicial
- Depositar valores na conta
- Sacar valores, com taxa fixa aplicada a cada saque
- Validação de entrada usando `TryParse` + laços de repetição, evitando exceções não tratadas em dados inválidos vindos do console
- Validação de regra de negócio mantida dentro da classe de domínio (`BankAccount`), independente de como o console coleta a entrada

## Tecnologias

- C# / .NET 10
- Aplicação Console

## Regras de Negócio

- Valores de depósito e saque não podem ser negativos
- Uma taxa fixa de $ 5,00 é aplicada a cada saque
- O saldo da conta pode ficar negativo (saldo devedor é permitido neste exercício)

## Exemplo

```
Digite o número da conta: 8532
Digite o titular da conta: Alex Green
Havera deposito inicial? (s/n) s
Digite o valor do deposito inicial: 500.00

Conta cadastrada com sucesso:
Conta: 8532, Titular: Alex Green, Saldo: $ 500.00

Entre com um valor para deposito: 200.00
Dados da conta atualizados com sucesso:
Conta: 8532, Titular: Alex Green, Saldo: $ 700.00

Entre com um valor para saque: 300.00
Dados da conta atualizados com sucesso:
Conta: 8532, Titular: Alex Green, Saldo: $ 395.00
```

## Estrutura do Projeto

```
BankAccountWithFee/
├── Program.cs
└── Models/
    └── BankAccount.cs
```

## Como Executar

```bash
dotnet run
```

## Autor

Gustavo Mollica
