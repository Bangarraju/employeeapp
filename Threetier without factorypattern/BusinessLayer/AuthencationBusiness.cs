using DomainLayer.Models;
using RepositoryLayer;

namespace BusinessLayer
{
    public class AuthencationBusiness
    {
        AuthencationRepo _authRepo;

        public AuthencationBusiness()
        {
            _authRepo = new AuthencationRepo();
        }

        /// <summary>
        /// validation of login email and password
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public bool ValidateLogin(LoginModel loginModel)
        {
            return _authRepo.ValidateLogin(loginModel);
        }

        /// <summary>
        /// validation of registration
        /// </summary>
        /// <param name="registrationModel"></param>
        /// <returns></returns>
        public bool ValidateRegister(RegistrationModel registrationModel)
        {
            Validations valid = new Validations();
            if (valid.ValidateEmail(registrationModel.Email) && valid.ValidatePassword(registrationModel.Password)
                && valid.ValidateName(registrationModel.FirstName) && valid.ValidateName(registrationModel.LastName))
            {
                return _authRepo.Register(registrationModel);
            }
            return false;
        }
    }
}