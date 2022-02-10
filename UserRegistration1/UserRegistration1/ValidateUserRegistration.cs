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
        private static string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFirstName(string FN)
        {
            try
            {

                Regex rg = new Regex(Regex_FirstName);
                return rg.IsMatch(FN);
            }
            catch (CustomException)
            {
                throw new CustomException
                    (CustomException.ExceptionType.INVALID_NAME, "Invalid User First Name.");
            }
        }
        public bool ValidateLastName(string LN)
        {
            try
            {

                Regex rg = new Regex(Regex_LastName);
                return rg.IsMatch(LN);
            }
            catch (CustomException)
            {
                throw new CustomException
                    (CustomException.ExceptionType.INVALID_NAME, "Invalid User Last Name.");
            }
        }
    }
}
