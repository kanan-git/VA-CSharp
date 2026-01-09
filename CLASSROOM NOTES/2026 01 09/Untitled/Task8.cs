// TASK: adi login olan metod yazin, evvelce username = "admin", password ="1234" olaraq teyin edin, istifadeciden ad ve sifre isteyin, duzdurse SUCCESSFULLY LOG, sehvdirse INVALID CREDENTIALS
Console.Write("Enter your username: ");
string input1 = Console.ReadLine();
Console.Write("Enter your password: ");
string input2 = Console.ReadLine();
Console.WriteLine("------------------------------------------");

Login(input1, input2);

static void Login(string username, string password)
{
    string user1_username = "admin";
    string user1_password = "1234";
    if(username == user1_username && password == user1_password)
    {
        Console.WriteLine("SUCCESSFULLY LOGGED IN");
        return;
    };
    Console.WriteLine("INVALID CREDENTIALS");
};
