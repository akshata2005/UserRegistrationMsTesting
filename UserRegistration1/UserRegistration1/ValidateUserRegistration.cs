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
        private static string Regex_Email = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
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
        public bool ValidateEmail(string Email)
        {
            try
            {

                Regex rg = new Regex(Regex_Email);
                return rg.IsMatch(Email);
            }
            catch (CustomException)
            {
                throw new CustomException
                    (CustomException.ExceptionType.INVALID_EMAIL, "Invalid User Email.");
            }
        }
    }
}
