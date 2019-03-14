using DomainLayer.Enums;
using DomainLayer.Models;
using RepositoryLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class UserBusiness
    {
        UserRepo _userRepo;

        public UserBusiness()
        {
            _userRepo = new UserRepo();
        }

        /// <summary>
        /// to get details of user from data layer
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public List<UserModel> GetUserDetails(UserRoleChoiceEnum role)
        {
            return _userRepo.GetUserDetails(role);
        }
    }
}
