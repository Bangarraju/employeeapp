using DomainLayer.Models;
using System.Linq;

namespace RepositoryLayer
{
    public class AuthencationRepo
    {
        public bool ValidateLogin(LoginModel loginModel)
        {
            return DataSource._userList.Any(m => m.Email == loginModel.Email &&
             m.Password == loginModel.Password);
        }

        public bool Register(RegistrationModel registrationModel)
        {
            if (!DataSource._userList.Any(m => m.Email == registrationModel.Email))
            {
                UserModel userModel = new UserModel();
                userModel.Email = registrationModel.Email;

                DataSource._userList.Add(userModel);
                return true;
            }

            return false;
        }
    }
}
