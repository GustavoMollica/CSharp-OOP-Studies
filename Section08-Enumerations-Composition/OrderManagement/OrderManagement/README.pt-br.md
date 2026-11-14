🇧🇷 Português | 🇺🇸 [English](README.md)

# Gerenciamento de Pedidos

Aplicação console simples em C# para praticar enumerações e composição: um pedido com um status, um cliente e uma lista de itens, cada item apontando para um produto.

## Visão Geral

Este exercício modela um pedido. O usuário cadastra o cliente, o status do pedido e N itens, informando o nome do produto, o preço e a quantidade de cada item. A aplicação então mostra um resumo do pedido com o momento, o status, os dados do cliente, cada item com seu subtotal e o total do pedido.

## Funcionalidades

- Composição: um `Order` tem um `Client` e uma lista de `OrderItem`, e cada `OrderItem` tem um `Product`
- Enum `OrderStatus` com valores explícitos (`PendingPayment`, `Processing`, `Shipped`, `Delivered`), aceito apenas pelo nome, sem diferenciar maiúsculas e minúsculas (números são recusados), usando `Enum.GetNames`
- Itens armazenados em uma lista `private readonly` e expostos como `IReadOnlyList<OrderItem>`, de modo que só podem ser alterados por `AddItem` e `RemoveItem`
- Cada `OrderItem` calcula o próprio subtotal, e o `Order.Total` soma esses valores
- Cada `OrderItem` guarda o preço do momento da compra, separado do preço do produto
- Momento do pedido definido uma única vez, na criação do pedido (`DateTime.Now` em um inicializador de auto-property), e somente leitura por fora (`private set`)
- Resumo do pedido montado com `StringBuilder`
- Propriedades `required` para o nome e o email do cliente, o nome do produto, o produto do item e o cliente do pedido
- Data de nascimento convertida com `TryParseExact` e o formato fixo `dd/MM/yyyy`, e preços convertidos com a cultura `pt-BR` fixa, independente da cultura da máquina
- Validação de entrada usando `TryParse` + laços de repetição com mensagens de erro específicas de cada campo
- Valores exibidos no formato de moeda `pt-BR`

## Tecnologias

- C# / .NET 10
- Aplicação Console

## Regras de Negócio

- O momento do pedido é a data e hora em que o pedido é criado
- O status deve ser `PendingPayment`, `Processing`, `Shipped` ou `Delivered`
- O nome do cliente não pode ser vazio, e o email deve conter um `@`
- A data de nascimento usa o formato `DD/MM/AAAA`
- Um pedido deve ter pelo menos um item
- O preço do produto e a quantidade do item devem ser maiores que zero
- O subtotal de um item é o preço multiplicado pela quantidade
- O total do pedido é a soma dos subtotais
- Valores decimais usam vírgula como separador (ex: `1000,00`)

## Exemplo

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

## Estrutura do Projeto

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

## Como Executar

```bash
dotnet run
```

## Autor

Gustavo Mollica
