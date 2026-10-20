using DormRoomRental.Models;

var dorm = new Dorm(10);

int n;
Console.WriteLine("Quantos estudantes vao alugar quartos?");
while(!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > dorm.Capacity)
{
    Console.WriteLine($"Valor invalido, digite um numero de 1 a {dorm.Capacity}");
}

for (int i = 0; i < n; i++)
{
    var student = new Student();
    int roomNumber;

    string? name;
    do
    {
        Console.WriteLine("Digite o nome do estudante:");
        name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
            Console.WriteLine("O nome nao pode ser vazio. Digite um nome valido");
    } while (string.IsNullOrWhiteSpace(name));
    student.Name = name;

    Console.WriteLine($"Digite o email do {student.Name}");
    while (!student.TrySetEmail(Console.ReadLine()))
    {
        Console.WriteLine("Valor invalido. Digite um email valido");
    }

    while (true)
    {
        Console.WriteLine($"Digite o numero do quarto a ser alugado. Quartos disponiveis: {dorm.GetAvailableRooms()}");
        if (!int.TryParse(Console.ReadLine(), out roomNumber))
        {
            Console.WriteLine("Valor inserido eh invalido. Digite novamente");
            continue;
        }

        if (!dorm.IsValidRoom(roomNumber))
        {
            Console.WriteLine($"Temos quarto de 1 a {dorm.Capacity}, digite o numero do quarto corretamente.");
            continue;
        }

        if (dorm.IsRoomOccupied(roomNumber))
        {
            Console.WriteLine("Quarto escolhido ja esta ocupado.");
            continue;
        }

        dorm.RentRoom(roomNumber, student);
        break;
    }
}

Console.WriteLine("\n\nQuartos alugados:");
for (int roomNumber = 1; roomNumber <= dorm.Capacity; roomNumber++)
{
    var student = dorm.GetStudent(roomNumber);
    if(student != null)
    {
        Console.WriteLine($"Quarto {roomNumber}");
        Console.WriteLine(student);
    }
}
