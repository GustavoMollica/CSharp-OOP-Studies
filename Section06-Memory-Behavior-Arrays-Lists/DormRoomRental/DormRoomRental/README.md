🇺🇸 English | 🇧🇷 [Português](README.pt-br.md)

# Dorm Room Rental

A simple console application built in C# to practice arrays: fixed-size collections, index access, and encapsulating the array inside a domain class.

## Overview

This exercise models a student dormitory with 10 rooms. The user informs how many students will rent a room and, for each one, registers the name, the email, and the chosen room. At the end, the application lists all the rented rooms with their respective students.

## Features

- Dormitory with 10 rooms, numbered from 1 to 10 and stored in a fixed-size array
- Conversion between room number and array index (`roomNumber - 1`) kept inside the `Dorm` class, so the rest of the code never deals with zero-based indexes
- The array is `private readonly` inside `Dorm`, so it can only be changed through the class methods
- List of available rooms shown before each room choice
- Rejection of non-existent rooms and rooms that are already occupied
- Email set through a `TrySetEmail` method that validates and assigns in a single step
- Input validation using `TryParse` + retry loops, avoiding unhandled exceptions on invalid console input
- Business rule validation kept inside the domain classes (`Dorm` and `Student`), independent of how the console collects input
- Final listing of the rented rooms using the `ToString()` override of `Student`

## Technologies

- C# / .NET 10
- Console Application

## Business Rules

- The dormitory has 10 rooms, numbered from 1 to 10
- Each room can be rented by only one student
- The number of students must be between 1 and the dormitory capacity
- The student name cannot be empty
- The student email must contain `@`
- Only existing and available rooms can be rented

## Example

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

## Project Structure

```
DormRoomRental/
├── Program.cs
└── Models/
    ├── Dorm.cs
    └── Student.cs
```

## How to Run

```bash
dotnet run
```

## Author

Gustavo Mollica
