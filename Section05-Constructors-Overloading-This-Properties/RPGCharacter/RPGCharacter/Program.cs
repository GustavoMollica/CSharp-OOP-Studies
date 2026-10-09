using RPGCharacter.Models;

Console.WriteLine("Criar personagem:");
string? name;
do
{
    Console.WriteLine("Digite o nome do personagem:");
    name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(name))
        Console.WriteLine("O nome nao pode ser vazio. Digite um nome valido");
} while (string.IsNullOrWhiteSpace(name));

string? classCharacter;
do
{
    Console.WriteLine("Digite a classe do personagem:");
    classCharacter = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(classCharacter))
        Console.WriteLine("A classe nao pode ser vazia. Digite uma classe valida");
} while (string.IsNullOrWhiteSpace(classCharacter));

var character = new Character(name, classCharacter);
Console.WriteLine($"Personagem criado: {character.Name} ({character.Class}) - {character}\n");

int damage;
while (true)
{
    Console.WriteLine($"{character.Name} deve sofrer dano nesse momento, quanto de dano ele ira sofrer?");

    if (!int.TryParse(Console.ReadLine(), out damage))
    {
        Console.WriteLine("Valor de dano invalido. Digite um numero");
        continue;
    }

    if (!character.TakeDamage(damage))    
    {
        Console.WriteLine("Valor nao pode ser negativo. Digite um numero valido");
        continue;
    }

    Console.WriteLine($"{character.Name} agora: {character}");
    if (character.IsDead)
    {
        Console.WriteLine($"{character.Name} esta morto");
        return;
    }
    break;
}

Console.WriteLine($"\n{character.Name} subiu de nivel");
character.LevelUp();
Console.WriteLine($"{character.Name} agora: {character}");

int healing;
while (true)
{
    Console.WriteLine($"{character.Name} deve receber cura nesse momento, quanto de cura ele ira receber?");

    if (!int.TryParse(Console.ReadLine(), out healing))
    {
        Console.WriteLine("Valor de cura invalido. Digite um numero");
        continue;
    }

    if (!character.Heal(healing))
    {
        Console.WriteLine("Valor nao pode ser negativo. Digite um numero valido");
        continue;
    }

    Console.WriteLine($"{character.Name} agora: {character}");
    break;
}


while (true)
{
    Console.WriteLine($"{character.Name} deve sofrer dano nesse momento, quanto de dano ele ira sofrer?");

    if (!int.TryParse(Console.ReadLine(), out damage))
    {
        Console.WriteLine("Valor de dano invalido. Digite um numero");
        continue;
    }

    if (!character.TakeDamage(damage))
    {
        Console.WriteLine("Valor nao pode ser negativo. Digite um numero valido");
        continue;
    }

    Console.WriteLine($"{character.Name} agora: {character}");
    if (character.IsDead)
        Console.WriteLine($"{character.Name} esta morto");
    break;
}