﻿using System;
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
            validateUserRegistration.PrintResult(fNameResult); // Printing first Name Of User

        }
    }
}