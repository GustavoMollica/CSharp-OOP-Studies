🇺🇸 English | 🇧🇷 [Português](README.pt-br.md)

# Bank Account With Fee

A simple console application built in C# to practice object-oriented programming fundamentals: classes, constructors, encapsulation, and input validation.

## Overview

This exercise models a basic bank account that supports account creation (with or without an initial deposit), deposits, and withdrawals. Every withdrawal applies a fixed fee.

## Features

- Create an account with or without an initial deposit
- Deposit funds into the account
- Withdraw funds, with a fixed fee applied to every withdrawal
- Input validation using `TryParse` + retry loops, avoiding unhandled exceptions on invalid console input
- Business rule validation kept inside the domain class (`BankAccount`), independent of how the console collects input

## Technologies

- C# / .NET 10
- Console Application

## Business Rules

- Deposit and withdrawal amounts cannot be negative
- A fixed fee of $ 5.00 is applied to every withdrawal
- The account balance is allowed to go negative (overdraft is permitted in this exercise)

## Example

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

## Project Structure

```
BankAccountWithFee/
├── Program.cs
└── Models/
    └── BankAccount.cs
```

## How to Run

```bash
dotnet run
```

## Author

Gustavo Mollica
