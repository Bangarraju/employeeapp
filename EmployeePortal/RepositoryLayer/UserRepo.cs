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
            return DataSource._userList.Where(m => m.IsStudent).ToList();
        }
    }
}
