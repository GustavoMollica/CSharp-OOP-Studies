
using System.Text.RegularExpressions;

namespace CpfValidator.Utils
{
    public static class ValidatorCpfUtils
    {
        public static bool IsCpfValid(string cpf)
        {
            if(!string.IsNullOrEmpty(cpf) && Regex.IsMatch(cpf, @"^\d{11}$"))
                return true;

            return false;
        }
    }
}
