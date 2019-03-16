package Inventory;
import Domain.*;
import Bussiness.*;

public class Authentication {
	AuthencationBusiness _authBusiness;
    public Authentication()
    {
        _authBusiness = new AuthencationBusiness();
    }
    public boolean Login(LoginModel loginModel)
    {
        return _authBusiness.ValidateLogin(loginModel);
    }
    public boolean Register(RegistrationModel registrationModel)
    {
        return _authBusiness.ValidateRegister(registrationModel);
    }
}
