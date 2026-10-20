🇧🇷 Português | 🇺🇸 [English](README.md)

# Aluguel de Quartos em Dormitório

Aplicação console simples em C# para praticar arrays: coleções de tamanho fixo, acesso por índice e encapsulamento do array dentro de uma classe de domínio.

## Visão Geral

Este exercício modela um dormitório estudantil com 10 quartos. O usuário informa quantos estudantes vão alugar um quarto e, para cada um, cadastra o nome, o email e o quarto escolhido. No final, a aplicação lista todos os quartos alugados com seus respectivos estudantes.

## Funcionalidades

- Dormitório com 10 quartos, numerados de 1 a 10 e armazenados em um array de tamanho fixo
- Conversão entre número do quarto e índice do array (`roomNumber - 1`) mantida dentro da classe `Dorm`, de modo que o restante do código nunca lida com índices que começam em zero
- O array é `private readonly` dentro de `Dorm`, então só pode ser alterado pelos métodos da classe
- Lista de quartos disponíveis exibida antes de cada escolha de quarto
- Rejeição de quartos inexistentes e de quartos que já estão ocupados
- Email definido por um método `TrySetEmail`, que valida e atribui em uma única etapa
- Validação de entrada usando `TryParse` + laços de repetição, evitando exceções não tratadas em dados inválidos vindos do console
- Validação de regra de negócio mantida dentro das classes de domínio (`Dorm` e `Student`), independente de como o console coleta a entrada
- Listagem final dos quartos alugados usando o `ToString()` sobrescrito de `Student`

## Tecnologias

- C# / .NET 10
- Aplicação Console

## Regras de Negócio

- O dormitório tem 10 quartos, numerados de 1 a 10
- Cada quarto só pode ser alugado por um estudante
- A quantidade de estudantes deve estar entre 1 e a capacidade do dormitório
- O nome do estudante não pode ser vazio
- O email do estudante deve conter `@`
- Só é possível alugar quartos que existem e estão disponíveis

## Exemplo

```
Quantos estudantes vao alugar quartos?
3
Digite o nome do estudante:
Maria Green
Digite o email do Maria Green
maria@gmail.com
Digite o numero do quarto a ser alugado. Quartos disponiveis:  1 2 3 4 5 6 7 8 9 10
5
Digite o nome do estudante:
Marco Blue
Digite o email do Marco Blue
marco@gmail.com
Digite o numero do quarto a ser alugado. Quartos disponiveis:  1 2 3 4 6 7 8 9 10
5
Quarto escolhido ja esta ocupado.
Digite o numero do quarto a ser alugado. Quartos disponiveis:  1 2 3 4 6 7 8 9 10
1
Digite o nome do estudante:
Alex Red
Digite o email do Alex Red
alex@gmail.com
Digite o numero do quarto a ser alugado. Quartos disponiveis:  2 3 4 6 7 8 9 10
10

Quartos alugados:
Quarto 1
Nome: Marco Blue
Email: marco@gmail.com
Quarto 5
Nome: Maria Green
Email: maria@gmail.com
Quarto 10
Nome: Alex Red
Email: alex@gmail.com
```

## Estrutura do Projeto

```
DormRoomRental/
├── Program.cs
└── Models/
    ├── Dorm.cs
    └── Student.cs
```

## Como Executar

```bash
dotnet run
```

## Autor

Gustavo Mollica
