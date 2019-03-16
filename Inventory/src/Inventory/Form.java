package Inventory;
import java.util.Scanner;
import Domain.*;

public class Form {
	Scanner input = new Scanner(System.in);
	public Form() {
		// TODO Auto-generated constructor stub
	}
	public void login()
	{
		LoginModel log = new LoginModel();
		System.out.println("user name/ emailid : ");
		log.email = input.nextLine();
		System.out.println("password : ");
		log.pswd = input.nextLine();
	}
	public void register()
	{
		RegistrationModel reg = new RegistrationModel();
		System.out.println("Full name : ");
		reg.name = input.nextLine();
		System.out.println("email Id : ");
		reg.email = input.nextLine();
		System.out.println("password : ");
		reg.pswd = input.nextLine();
		System.out.println("are you admin (true/false) : ");
		reg.isadmin = input.nextBoolean();
	}
}