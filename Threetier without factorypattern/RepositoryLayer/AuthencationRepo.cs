using DomainLayer.Models;
using System.Linq;

namespace RepositoryLayer
{
    public class AuthencationRepo
    {
        /// <summary>
        /// validate login in data layer
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public bool ValidateLogin(LoginModel loginModel)
        {
            return DataSource._userList.Any(m => m.Email == loginModel.Email &&
             m.Password == loginModel.Password);
        }

        /// <summary>
        /// validate registration 
        /// </summary>
        /// <param name="registrationModel"></param>
        /// <returns></returns>
        public bool Register(RegistrationModel registrationModel)
        {
            if (!DataSource._userList.Any(m => m.Email == registrationModel.Email))
            {
                UserModel userModel = new UserModel();
                userModel.Email = registrationModel.Email;
                userModel.Password = registrationModel.Password;
                userModel.FirstName = registrationModel.FirstName;
                userModel.LastName = registrationModel.LastName;
                userModel.IsStudent = registrationModel.IsStudent;
                DataSource._userList.Add(userModel);
                return true;
            }

            return false;
        }
    }
}
