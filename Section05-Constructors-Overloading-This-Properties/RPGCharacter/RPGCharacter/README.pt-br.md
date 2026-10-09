🇧🇷 Português | 🇺🇸 [English](README.md)

# Personagem de RPG

Aplicação console simples em C# para praticar fundamentos de programação orientada a objetos: construtores, propriedades, encapsulamento e validação de entrada.

## Visão Geral

Este exercício modela um personagem básico de RPG, criado com nome e classe, que pode sofrer dano, receber cura e subir de nível. A vida do personagem é mantida dentro de limites válidos, e um personagem morto não pode mais sofrer dano nem ser curado.

## Funcionalidades

- Criar um personagem com nome e classe
- Sofrer dano, sem nunca ficar abaixo de 0 de vida
- Receber cura, sem nunca ultrapassar a vida máxima atual
- Subir de nível, aumentando o poder de ataque, a vida máxima e a vida atual
- Propriedade calculada `IsDead` para verificar se o personagem está morto
- Propriedades com `private set`, de modo que nível, vida e poder de ataque só mudam pelos métodos da classe
- Validação de entrada usando `TryParse` + laços de repetição, evitando exceções não tratadas em dados inválidos vindos do console
- Validação de regra de negócio mantida dentro da classe de domínio (`Character`), independente de como o console coleta a entrada

## Tecnologias

- C# / .NET 10
- Aplicação Console

## Regras de Negócio

- Um novo personagem começa no nível 1, com 100 de vida e 15 de poder de ataque
- Nome e classe não podem ser vazios
- Valores de dano e cura não podem ser negativos
- A vida não pode ficar abaixo de 0 nem ultrapassar a vida máxima atual
- Um personagem morto (0 de vida) não pode sofrer dano nem ser curado
- Cada subida de nível adiciona +5 de poder de ataque, +20 de vida máxima e cura 20 de vida (limitada ao novo máximo)

## Exemplo

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

## Estrutura do Projeto

```
RPGCharacter/
├── Program.cs
└── Models/
    └── Character.cs
```

## Como Executar

```bash
dotnet run
```

## Autor

Gustavo Mollica
