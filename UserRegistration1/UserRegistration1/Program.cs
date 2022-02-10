using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //class and it's object
            ValidateUserRegistration validateUserRegistration = new ValidateUserRegistration();

            //firstname
            Console.WriteLine("Enter Your First Name : ");
            string firstName = Console.ReadLine();
            bool fNameResult = validateUserRegistration.ValidateFirstName(firstName); //Validating First Name Of User
            //validateUserRegistration.PrintResult(fNameResult); // Printing first Name Of User

            Console.WriteLine("Enter your last name : ");
            string lastName = Console.ReadLine();
            bool lNameResult = validateUserRegistration.ValidateFirstName(lastName); //Validating Last Name Of User
                                                                                     //validateUserRegistration.PrintResult(lNameResult); //Printing Last Name Of User
                                                                                     //emailId
            Console.WriteLine("Enter Your Email : ");
            string email = Console.ReadLine();
            bool emailResult = validateUserRegistration.ValidateEmail(email); //Validating email Of User
           validateUserRegistration.PrintResult(emailResult); //Print Email Of User

            Console.WriteLine("Enter your Mobile Number : ");
            string mobileNo = Console.ReadLine();
            bool mobileNoResult = validateUserRegistration.ValidateMobileNo(mobileNo); //Validating Mobile Number Of User
            validateUserRegistration.PrintResult(mobileNoResult); //Print Mobile Number Of User

            Console.WriteLine("Enter your Password : ");
            string password = Console.ReadLine();
            bool passwordResult = validateUserRegistration.ValidatePassword(password); //Validating Password Of User
            validateUserRegistration.PrintResult(passwordResult);
        }
    }
}
