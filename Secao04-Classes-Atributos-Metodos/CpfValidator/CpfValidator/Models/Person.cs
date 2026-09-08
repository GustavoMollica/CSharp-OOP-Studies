
namespace CpfValidator.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Cpf {  get; set; }
        public double Height { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Nome: {FullName}\n" +
                $"Cpf: {Cpf}";
        }
    }
}
