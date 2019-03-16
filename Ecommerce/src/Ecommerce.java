import java.util.*;

public class Ecommerce {
	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		Bal objBLayer = new Bal();
		Form objform = new Form();
        System.out.println("1.Login\n2.Register");
        switch(input.nextLine())
        {
            case "1": objform.login(objBLayer);
                       break;
            case "2" :objform.register(objBLayer);
            default : break;
        }
	}
}
