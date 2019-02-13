using DomainLayer.Enums;
using DomainLayer.Models;
using System.Collections.Generic;

namespace RepositoryLayer
{
    public class UserBusiness
    {
        UserRepo _userRepo;

        public UserBusiness()
        {
            _userRepo = new UserRepo();
        }

        public List<UserModel> GetUserDetails(UserRoleChoiceEnum role)
        {
            return _userRepo.GetUserDetails(role);
        }
    }
}
