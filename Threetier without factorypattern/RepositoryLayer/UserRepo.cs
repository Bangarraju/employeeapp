using DomainLayer.Enums;
using DomainLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryLayer
{
    public class UserRepo
    {
        public List<UserModel> GetUserDetails(UserRoleChoiceEnum role)
        {
            if (role == UserRoleChoiceEnum.Student)
            {
                return DataSource._userList.Where(m => m.IsStudent).ToList();
            }
            else if (role == UserRoleChoiceEnum.Other)
            {
                return DataSource._userList.Where(m => !m.IsStudent).ToList();
            }
            else
            {
                return DataSource._userList;
            }
        }
    }
}
