package Repository;
import Domain.*;

public class AuthenticationRepo {

	 /// <summary>
    /// validate login in data layer
    /// </summary>
    /// <param name="loginModel"></param>
    /// <returns></returns>
    public boolean ValidateLogin(LoginModel loginModel)
    {
        return DataSource._userList.Any(m => m.email == loginModel.email &&
         m.pswd == loginModel.pswd);
    }

    /// <summary>
    /// validate registration 
    /// </summary>
    /// <param name="registrationModel"></param>
    /// <returns></returns>
    public boolean Register(RegistrationModel registrationModel)
    {
        if (!DataSource._userList.Any(m => m.email == registrationModel.email))
        {
            UserModel userModel = new UserModel();
            userModel.email = registrationModel.email;
            userModel.pswd = registrationModel.pswd;
            userModel.name = registrationModel.name;
            userModel.isadmin = registrationModel.isadmin;
            DataSource._userList.add(userModel);
            return true;
        }

        return false;
    }

}
