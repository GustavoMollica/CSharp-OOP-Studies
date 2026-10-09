🇺🇸 English | 🇧🇷 [Português](README.pt-br.md)

# RPG Character

A simple console application built in C# to practice object-oriented programming fundamentals: constructors, properties, encapsulation, and input validation.

## Overview

This exercise models a basic RPG character that is created with a name and a class, can take damage, heal, and level up. The character's health is kept within valid limits, and a dead character can no longer take damage or be healed.

## Features

- Create a character with a name and a class
- Take damage, never dropping below 0 HP
- Heal, never exceeding the current maximum HP
- Level up, increasing attack power, maximum HP, and current HP
- Calculated property `IsDead` to check whether the character is dead
- Properties with `private set`, so level, HP, and attack power can only change through the class methods
- Input validation using `TryParse` + retry loops, avoiding unhandled exceptions on invalid console input
- Business rule validation kept inside the domain class (`Character`), independent of how the console collects input

## Technologies

- C# / .NET 10
- Console Application

## Business Rules

- A new character starts at level 1, with 100 HP and 15 attack power
- Name and class cannot be empty
- Damage and healing amounts cannot be negative
- HP cannot drop below 0 or exceed the current maximum HP
- A dead character (0 HP) cannot take damage or be healed
- Each level up adds +5 attack power, +20 maximum HP, and heals 20 HP (limited to the new maximum)

## Example

```
Criar personagem:
Digite o nome do personagem:
Aragorn
Digite a classe do personagem:
Guerreiro
Personagem criado: Aragorn (Guerreiro) - Nivel 1 - HP: 100/100 - Ataque: 15

Aragorn deve sofrer dano nesse momento, quanto de dano ele ira sofrer?
30
Aragorn agora: Nivel 1 - HP: 70/100 - Ataque: 15

Aragorn subiu de nivel
Aragorn agora: Nivel 2 - HP: 90/120 - Ataque: 20
Aragorn deve receber cura nesse momento, quanto de cura ele ira receber?
50
Aragorn agora: Nivel 2 - HP: 120/120 - Ataque: 20
Aragorn deve sofrer dano nesse momento, quanto de dano ele ira sofrer?
40
Aragorn agora: Nivel 2 - HP: 80/120 - Ataque: 20
```

## Project Structure

```
RPGCharacter/
├── Program.cs
└── Models/
    └── Character.cs
```

## How to Run

```bash
dotnet run
```

## Author

Gustavo Mollica
