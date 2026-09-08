namespace UserManagement.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public static int TotalUserCount { get; private set; } = 0;

        public User()
        {
            TotalUserCount++;
        }

        public override string ToString()
        {
            return $"Nome: {Name}\nEmail: {Email}";
        }
    }
}