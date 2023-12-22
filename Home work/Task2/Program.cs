var per = new User();
per.FirstName = "Mustafo";
per.LastName = "Barotov";
per.Username = "barotov1010";
per.Password = "1234";

System.Console.WriteLine($"{per.GetFullInfo()}");




class User
{
    public string FirstName;
    public string LastName;
    public string Username;
    public string Password;
    public bool IsLoggedIn;

    public void Login(string username, string password)
    {
        if(username == password)
        {
            System.Console.WriteLine( "Истифодабаранда бомуваффақият ворид шуд");
        }
        else
        {
            System.Console.WriteLine("Парол ё номи Истифодабаранда шумо нодуруст аст");
        };
    }
    public void Logout()
    {
        IsLoggedIn = false;
    }
    public String GetFullInfo()
    {
        return $"{FirstName} {LastName} - {IsLoggedIn}";
    }
}


