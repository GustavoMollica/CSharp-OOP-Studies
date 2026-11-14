🇺🇸 English | 🇧🇷 [Português](README.pt-br.md)

# Blog Posts

A simple console application built in C# to practice composition and `StringBuilder`: a post made of a list of comments, and a text built piece by piece.

## Overview

This exercise models blog posts. The user types the title and the description of two posts, and each post receives its own comments. The application then shows every post with its likes, the moment it was published, its content and its comments.

## Features

- Composition: a `Post` has a list of `Comment`
- Comments stored in a `private readonly` list and exposed as `IReadOnlyList<Comment>`, so they can only be changed through `AddComment` and `RemoveComment`
- `Post.ToString()` built with `StringBuilder`, including the post's comments
- Likes generated randomly only once, when the post is created (`Random.Shared` in an auto-property initializer), and read-only from outside (`private set`)
- Publication moment displayed with a fixed `dd/MM/yyyy HH:mm:ss` format and `InvariantCulture`, independent of the machine culture
- `required` properties for the post title, the post content and the comment text
- Input validation with retry loops, avoiding empty titles and descriptions

## Technologies

- C# / .NET 10
- Console Application

## Business Rules

- Each post has a title, a description, a number of likes and a publication moment
- Likes are a random number from 1 to 1000, defined when the post is created
- The publication moment is the date and time when the post is created
- The title and the description cannot be empty
- Each post has its own comments
- Comments can only be added or removed through the post

## Example

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

## Project Structure

```
BlogPosts/
├── Program.cs
└── Entities/
    ├── Comment.cs
    └── Post.cs
```

## How to Run

```bash
dotnet run
```

## Author

Gustavo Mollica
