using DomainLayer;
using DomainLayer.Enums;
using DomainLayer.Models;
using System;


namespace ConApp
{
    class Login
    {
        public void LoginPage()
        {
            Authentication authentication = new Authentication();

            LoginModel loginModel = new LoginModel();

            Console.Write(StringLiterals._emailId);
            loginModel.Email = Console.ReadLine();

            Console.Write(StringLiterals._password);
            loginModel.Password = Console.ReadLine();

            if (authentication.Login(loginModel))
            {
                UserModule user = new UserModule();
                Console.WriteLine(StringLiterals._whichInfo);
                int role = Convert.ToInt32(Console.ReadLine());
                user.GetUserDetails((UserRoleChoiceEnum)role);
            }
            else
            {
                Console.WriteLine(StringLiterals._invalidDetails);
            }
        }
    }
}