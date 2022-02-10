using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration1
{
    public class ValidateUserRegistration
    {
        private static string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFirstName(string FN)
        {
            return Regex.IsMatch(FN, Regex_FirstName);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }
}
