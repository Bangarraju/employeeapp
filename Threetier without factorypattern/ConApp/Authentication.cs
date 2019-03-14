using BusinessLayer;
using DomainLayer.Models;

namespace ConApp
{
    class Authentication
    {
        AuthencationBusiness _authBusiness;
        public Authentication()
        {
            _authBusiness = new AuthencationBusiness();
        }
        internal bool Login(LoginModel loginModel)
        {
            return _authBusiness.ValidateLogin(loginModel);
        }
        internal bool Register(RegistrationModel registrationModel)
        {
            return _authBusiness.ValidateRegister(registrationModel);
        }
    }
}
