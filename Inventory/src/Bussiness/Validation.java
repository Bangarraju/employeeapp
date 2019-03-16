package Bussiness;

public class Validation {

	public boolean ValidateEmail(String email)
    {
        if (email.contains("@") && email.contains(".com"))
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// Validation of Password
    /// </summary>
    /// <param name="password"></param>
    /// <returns></returns>
    public boolean ValidatePassword(String password)
    {
        int condcount = 0;
        //for capital letters condition
        for(char c : password.toCharArray())
        {
            if (c >= 'A' && c <= 'Z')
            {
                condcount++;
                break;
            }
        }
        //for digits checking condition
        for(char c : password.toCharArray())
        {
            if (c >= '0' && c <= '9')
            {
                condcount++;
                break;
            }
        }
        //for length of password checking condition
        if (password.length() <= 15 && password.length() >= 8)
        {
            condcount++;
        }
        if (condcount == 3)
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// validate name
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public boolean ValidateName(String name)
    {
        if (name.length() > 0)
        {
            return true;
        }
        return false;
    }

}
