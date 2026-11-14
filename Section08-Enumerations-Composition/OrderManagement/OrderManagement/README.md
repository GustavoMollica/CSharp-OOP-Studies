🇺🇸 English | 🇧🇷 [Português](README.pt-br.md)

# Order Management

A simple console application built in C# to practice enumerations and composition: an order with a status, a client and a list of items, each item pointing to a product.

## Overview

This exercise models an order. The user registers the client, the order status and N items, informing the product name, its price and the quantity of each item. The application then shows an order summary with the order moment, its status, the client data, every item with its subtotal and the order total.

## Features

- Composition: an `Order` has a `Client` and a list of `OrderItem`, and each `OrderItem` has a `Product`
- `OrderStatus` enum with explicit values (`PendingPayment`, `Processing`, `Shipped`, `Delivered`), accepted only by name, case-insensitively (numbers are rejected), using `Enum.GetNames`
- Items stored in a `private readonly` list and exposed as `IReadOnlyList<OrderItem>`, so they can only be changed through `AddItem` and `RemoveItem`
- Each `OrderItem` calculates its own subtotal, and `Order.Total` sums them
- Each `OrderItem` keeps the price of the moment of the purchase, separate from the product's price
- Order moment set only once, when the order is created (`DateTime.Now` in an auto-property initializer), and read-only from outside (`private set`)
- Order summary built with `StringBuilder`
- `required` properties for the client name and email, the product name, the item's product and the order's client
- Birth date parsed with `TryParseExact` and the fixed `dd/MM/yyyy` format, and prices parsed with a fixed `pt-BR` culture, independent of the machine culture
- Input validation using `TryParse` + retry loops with field-specific error messages
- Values displayed as `pt-BR` currency

## Technologies

- C# / .NET 10
- Console Application

## Business Rules

- The order moment is the date and time when the order is created
- The status must be `PendingPayment`, `Processing`, `Shipped` or `Delivered`
- The client name cannot be empty, and the email must contain an `@`
- The birth date uses the `DD/MM/AAAA` format
- An order must have at least one item
- The product price and the item quantity must be greater than zero
- The subtotal of an item is its price multiplied by its quantity
- The order total is the sum of the subtotals
- Decimal values use a comma as the separator (e.g. `1000,00`)

## Example

```
Entre com os dados do cliente:
Digite o nome:
Alex Green
Digite o email de Alex Green:
alex@gmail.com
Digite a data de nascimento de Alex Green (DD/MM/AAAA):
15/03/1985
Entre com os dados do pedido:
Digite o status (PendingPayment/Processing/Shipped/Delivered):
processando
Valor invalido. Digite uma das opcoes: PendingPayment, Processing, Shipped ou Delivered.
processing
Quantos itens para este pedido?
2
Entre com os dados do 1° item:
Nome do produto:
TV
Preco do produto (ex: 1000,00):
1000,00
Quantidade:
1
Entre com os dados do 2° item:
Nome do produto:
Mouse
Preco do produto (ex: 1000,00):
40,00
Quantidade:
2

RESUMO DO PEDIDO:
Momento do pedido: 13/11/2026 23:54:08
Status do pedido: Processing
Cliente: Alex Green (15/03/1985) - alex@gmail.com
Itens do pedido:
TV, R$ 1.000,00, Quantidade: 1, Subtotal: R$ 1.000,00
Mouse, R$ 40,00, Quantidade: 2, Subtotal: R$ 80,00
Preco total: R$ 1.080,00
```

## Project Structure

```
OrderManagement/
├── Program.cs
└── Entities/
    ├── Client.cs
    ├── Order.cs
    ├── OrderItem.cs
    ├── Product.cs
    └── Enums/
        └── OrderStatus.cs
```

## How to Run

```bash
dotnet run
```

## Author

Gustavo Mollica
