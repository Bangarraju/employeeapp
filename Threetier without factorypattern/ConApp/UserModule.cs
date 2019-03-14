using BusinessLayer;
using DomainLayer;
using DomainLayer.Enums;
using System;

namespace ConApp
{
    class UserModule
    {
        internal void GetUserDetails(UserRoleChoiceEnum role)
        {
            UserBusiness getDetails = new UserBusiness();
            switch (role)
            {
                case UserRoleChoiceEnum.Student:
                    var stu = getDetails.GetUserDetails(role);
                    for(int index=0; index<stu.Count; index++)
                    {
                        Console.WriteLine(StringLiterals._firstName + stu[index].FirstName);
                        Console.WriteLine(StringLiterals._lastName + stu[index].LastName);
                        Console.WriteLine(StringLiterals._emailId + stu[index].Email);
                        Console.WriteLine();
                    }
                    break;
                case UserRoleChoiceEnum.Other:
                    var other = getDetails.GetUserDetails(role);
                    for (int index = 0; index < other.Count; index++)
                    {
                        Console.WriteLine(StringLiterals._firstName + other[index].FirstName);
                        Console.WriteLine(StringLiterals._lastName + other[index].LastName);
                        Console.WriteLine(StringLiterals._emailId + other[index].Email);
                        Console.WriteLine(StringLiterals._isStudent + other[index].IsStudent);
                        Console.WriteLine();
                    }
                    break;
                case UserRoleChoiceEnum.All:
                    var allinfo = getDetails.GetUserDetails(role);
                    for (int index = 0; index < allinfo.Count; index++)
                    {
                        Console.WriteLine(StringLiterals._firstName + allinfo[index].FirstName);
                        Console.WriteLine(StringLiterals._lastName + allinfo[index].LastName);
                        Console.WriteLine(StringLiterals._emailId + allinfo[index].Email);
                        Console.WriteLine(StringLiterals._isStudent + allinfo[index].IsStudent);
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
