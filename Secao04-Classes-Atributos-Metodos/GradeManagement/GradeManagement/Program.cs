using GradeManagement.Models;
using System.Globalization;

var student = new Student();

Console.WriteLine("Insira os dados do aluno:");
Console.WriteLine("Nome do aluno:");
student.Name = Console.ReadLine();

Console.WriteLine($"Primeira nota do {student.Name}:");
string erro;
do
{
    bool isNumber = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double noteA);
    if (!isNumber)
    {
        erro = "Valor invalido. Digite um numero.";
        Console.WriteLine(erro);
        continue;
    }

    erro = student.SetNoteA(noteA);
    if (!string.IsNullOrEmpty(erro))
        Console.WriteLine(erro);
}
while (!string.IsNullOrEmpty(erro));

Console.WriteLine($"Segunda nota do {student.Name}:");
do
{
    bool isNumber = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double noteB);
    if (!isNumber)
    {
        erro = "Valor invalido. Digite um numero.";
        Console.WriteLine(erro);
        continue;
    }

    erro = student.SetNoteB(noteB);
    if (!string.IsNullOrEmpty(erro))
        Console.WriteLine(erro);
}
while (!string.IsNullOrEmpty(erro));

Console.WriteLine($"Terceira nota do {student.Name}:");
do
{
    bool isNumber = double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double noteC);
    if (!isNumber)
    {
        erro = "Valor invalido. Digite um numero.";
        Console.WriteLine(erro);
        continue;
    }

    erro = student.SetNoteC(noteC);
    if (!string.IsNullOrEmpty(erro))
        Console.WriteLine(erro);
}
while (!string.IsNullOrEmpty(erro));

Console.WriteLine($"NOTA FINAL = {student.FinalGrade.ToString("F2", CultureInfo.InvariantCulture)}");
if (student.IsApproved())
    Console.WriteLine($"APROVADO");
else
{
    Console.WriteLine("REPROVADO\n" +
        $"FALTARAM: {student.RemainingPoints().ToString("F2", CultureInfo.InvariantCulture)} pontos");
}