namespace DormRoomRental.Models;

public class Student
{
    public string Name { get; set; }
    public string Email { get; private set; }

    public bool TrySetEmail(string? email)
    {
        if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            return false;

        Email = email;
        return true;
    }

    public override string ToString()
    {
        return $"Nome: {Name}\n" +
            $"Email: {Email}";
    }
}
