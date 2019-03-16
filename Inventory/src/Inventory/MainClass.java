package Inventory;
import java.util.Scanner;

public class MainClass {

	public MainClass() {
		// TODO Auto-generated constructor stub
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		System.out.println("1.input\n2. register");
		int choice = input.nextInt();
		input.nextLine();
		switch(choice)
		{
			case 1 :Form login = new Form();
					login.login();
					break;
			case 2 :Form Register = new Form();
					Register.register(); 
					break;
			default : System.out.println("invalid choice");
						break;
		}
		input.close();
	}
}