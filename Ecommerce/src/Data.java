import java.util.*;

class Customer
    {
        public String Name;
        public String EmailId;
        public String Pswd;
        public boolean isadmin;
        public Customer(String Name, String EmailId, String Pswd, boolean isadmin)
        {
            this.Name = Name;
            this.EmailId = EmailId;
            this.Pswd = Pswd;
            this.isadmin = isadmin;
        }
    }
public class Data {

	public List<Customer> Info = new ArrayList<Customer>();
    //set the information in to list
    public void SetInfo(String Name, String EmailId, String Password, boolean isadmin)
    {
        Info.add(new Customer(Name, EmailId, Password, isadmin));
    }
    public List<Customer> GetInfo()
    {
        return Info;
    }
    //for student information
    public String StudentInfo()
    {
        String result = "";
        for (int index = 0; index < Info.size(); index++)
        {
            if (Info[index].TypeOfReg == 1)
            {
                result = result + Info[index].FstName +"\t\t" + Info[index].LstName+"\t\t" 
                                + Info[index].EmailId + "\n" ;            
            }
        }
        return result;
    }
    // other than student information
    public String OthersInfo()
    {
        String result = "";
        for (int index = 0; index < Info.size(); index++)
        {
            if (Info[index].TypeOfReg == 2)
            {
                result = result + Info[index].FstName +"\t\t" + Info[index].LstName+"\t\t" 
                                + Info[index].EmailId + "\n" ;            
            }
        }
        return result;
    }
    //all information
    public String AllInfo()
    {
        string result = string.Empty;
        for (int index = 0; index < Info.Count; index++)
        {
            result = result + Info[index].FstName +"\t\t" + Info[index].LstName+"\t\t"  
                           + Info[index].EmailId +"\t" + Info[index].TypeOfReg +"\n" ;           
        }
        return result;
    }

}
