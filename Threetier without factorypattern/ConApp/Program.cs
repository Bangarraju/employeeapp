using DomainLayer.Enums;
using System;

namespace ConApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Login log = new Login();

            Registration reg = new Registration();

            l1: Console.WriteLine("1.Login\n2.Register\n3.exit");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case (int)HomePageChoiceEnum.Login:
                    log.LoginPage();
                    goto l1;
                case (int)HomePageChoiceEnum.Registration:
                    reg.RegistrationPage();
                    goto l1;
                case (int)HomePageChoiceEnum.Exit:
                    break;
            }
            Console.ReadLine();
        }
    }
}
