
public class Bal {

	public Data ObjDL = new Data();
    //set the data into list
    public void SetInfo(String Name, String EmailId, String Password, boolean isadmin)
    {
        ObjDL.SetInfo(Name, EmailId, Password, isadmin);
    }

    //validate first name
    //validate last name
    public boolean IsValidName(String LastName)
    {
        boolean Flag;
        if (LastName.length() > 0)
        {
            Flag = true;
        }
        else
        {
            Flag = false;
        }
        return Flag;
    }
    //validation of email Id by checking "@" and ".com"
    public boolean IsValidEmailId(String EmailId)
    {
        boolean Flag;
        var info = ObjDL.GetInfo();
        if(EmailId.contains("@") && EmailId.contains(".com"))
        {
            Flag = true;
        }
        else
        {
            Flag = false;
        }
        for(int i=0; i<info.Count;i++)
        {
            if(info[i].EmailId == EmailId)
                return false;
        }
        return Flag;
    }
    //validation of password with capital letters , numbers and limit the length of password 
    public boolean IsValidPswd(String Password)
    {
        int condcount = 0;
        //for capital letters condition
        for(char c : Password.toCharArray())
        {
            if (c >= 'A' && c <= 'Z')
            {
                condcount++;
                break;
            }
        }
        //for digits checking condition
        for(char c : Password.toCharArray())
        {
            if (c >= '0' && c <= '9')
            {
                condcount++;
                break;
            }
        }
        //for length of password checking condition
        if(Password.length() <=15 || Password.length() >=8)
        {
            condcount++;
        }
        if(condcount == 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // for validating login email
    public boolean IsValidLoginEmailId(String CEmailId)
    {
        boolean Flag = false;
        var info = ObjDL.GetInfo();
        for (int i = 0; i < info.Count; i++)
        {
            if (info[i].EmailId == CEmailId)
            {
                Flag = true;
                return Flag;
            }
        }
        return Flag;
    }
    //for validating login password
    public boolean IsValidLoginPswd(String EmailId, String Password)
    {
        boolean Flag = false;
        var info = ObjDL.GetInfo();
        for (int i = 0; i < info.Count; i++)
        {
            if(info[i].EmailId == EmailId && info[i].Pswd == Password)
            {
                Flag = true;
                return Flag;
            }
        }
        return Flag;
    }
    //to get student information
    public String GetStudentInfo()
    {
        return ObjDL.StudentInfo();;
    }
    //to get other than student information
    public String GetOtherInfo()
    {
        return ObjDL.OthersInfo();
    }
    //to get all the registerers information
    public String GetAllInfo()
    {
        return ObjDL.AllInfo();
    }
}
