🇧🇷 Português | 🇺🇸 [English](README.md)

# Posts de Blog

Aplicação console simples em C# para praticar composição e `StringBuilder`: um post formado por uma lista de comentários, e um texto montado parte por parte.

## Visão Geral

Este exercício modela posts de um blog. O usuário digita o título e a descrição de dois posts, e cada post recebe os próprios comentários. A aplicação então mostra cada post com suas curtidas, o momento da publicação, o conteúdo e os comentários.

## Funcionalidades

- Composição: um `Post` tem uma lista de `Comment`
- Comentários armazenados em uma lista `private readonly` e expostos como `IReadOnlyList<Comment>`, de modo que só podem ser alterados por `AddComment` e `RemoveComment`
- `Post.ToString()` montado com `StringBuilder`, incluindo os comentários do post
- Curtidas geradas aleatoriamente uma única vez, na criação do post (`Random.Shared` em um inicializador de auto-property), e somente leitura por fora (`private set`)
- Momento da publicação exibido com o formato fixo `dd/MM/yyyy HH:mm:ss` e `InvariantCulture`, independente da cultura da máquina
- Propriedades `required` para o título do post, o conteúdo do post e o texto do comentário
- Validação de entrada com laços de repetição, evitando títulos e descrições vazios

## Tecnologias

- C# / .NET 10
- Aplicação Console

## Regras de Negócio

- Cada post tem um título, uma descrição, uma quantidade de curtidas e um momento de publicação
- As curtidas são um número aleatório de 1 a 1000, definido na criação do post
- O momento de publicação é a data e hora em que o post é criado
- O título e a descrição não podem ser vazios
- Cada post tem os próprios comentários
- Comentários só podem ser adicionados ou removidos pelo próprio post

## Exemplo

```
Digite o titulo do 1° post:
Viagem para a Nova Zelandia
Digite a descricao do 1° post:
Vou visitar esse pais maravilhoso!
Digite o titulo do 2° post:

Valor invalido. Digite um titulo valido.
Boa noite pessoal
Digite a descricao do 2° post:
Ate amanha


Posts publicados:
Viagem para a Nova Zelandia
976 curtidas - 13/11/2026 21:16:29
Vou visitar esse pais maravilhoso!
Comentarios:
Parabensss pelo seu momento.
Incrivell momentooo.

Boa noite pessoal
37 curtidas - 13/11/2026 21:16:29
Ate amanha
Comentarios:
uhulll, parabensssss.
Que a Forca esteja com voce.
```

## Estrutura do Projeto

```
BlogPosts/
├── Program.cs
└── Entities/
    ├── Comment.cs
    └── Post.cs
```

## Como Executar

```bash
dotnet run
```

## Autor

Gustavo Mollica
