import java.util.*;

public class Form {
	public void login(Bal objBlayer)
	{
		Scanner in = new Scanner(System.in);
		String EmailId, Password;
        int type;
        System.out.println("EmailId : ");
        EmailId = in.nextLine();
        System.out.println("Password : ");
        Password = in.nextLine();
        //checking wether email and password is valid or not
        if(objBlayer.IsValidLoginEmailId(EmailId) && objBlayer.IsValidLoginPswd(EmailId, Password))
        {
        	
        }
        else 
        {
            System.out.println("Enter valid Credentials");
        }
	}
	public void register(Bal objBlayer)
	{
		Scanner in = new Scanner(System.in);
		String Name, EmailId, Password;
        boolean isadmin;
        System.out.println("LastName: ");
        Name = in.nextLine();
        System.out.println("EmailId: ");
        EmailId = in.nextLine();
        System.out.println("Password: ");
        Password = in.nextLine();                      
        System.out.println("is admin");
        System.out.println("true/false");
        isadmin = in.nextBoolean();
        if(objBlayer.IsValidName(Name) 
            && objBlayer.IsValidEmailId(EmailId) 
            && objBlayer.IsValidPswd(Password))
            {
                //to store the data in to list
        	objBlayer.SetInfo(Name, EmailId, Password, isadmin);
            }
            else 
            {
            	System.out.println("Enter Valid details i.e valid email and valid password with one caps ,one digit and length between 8 to 15");
            }
	}
}
