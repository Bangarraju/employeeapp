using DomainLayer;
using DomainLayer.Models;
using System;

namespace ConApp
{
    class Registration
    {
        public void RegistrationPage()
        {
            RegistrationModel register = new RegistrationModel();

            Console.Write(StringLiterals._firstName);
            register.FirstName = Console.ReadLine();

            Console.Write(StringLiterals._lastName);
            register.LastName = Console.ReadLine();

            Console.Write(StringLiterals._emailId);
            register.Email = Console.ReadLine();

            Console.Write(StringLiterals._password);
            register.Password = Console.ReadLine();

            Console.Write(StringLiterals._student);
            register.IsStudent = Convert.ToBoolean(Console.ReadLine());

            Authentication authentication = new Authentication();
            if (authentication.Register(register))
            {
                Console.WriteLine("Sucessfully registered");
            }
            else
            {
                Console.WriteLine("Invalid details");
            }
        }
    }
}
