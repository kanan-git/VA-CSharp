using Models;

public class Person
{
    private string _username;
    private string _password;
    private string _firstname;
    private string _lastname;
    private string _dateofbirth;
    private int _age;

    public string Username
    {
        get
        {
            return _username;
        }
        set
        {
            Validator tester1 = new Validator();
            if(tester1.IsValidUsername(value))
            {
                _username = value;
            };
        }
    }
    public string Password
    {
        get
        {
            return _password;
        }
        set
        {
            Validator tester2 = new Validator();
            if(tester2.IsValidPassword(value))
            {
                _password = value;
            };
        }
    }
    public string Firstname
    {
        get
        {
            return _firstname;
        }
        set
        {
            Validator tester3 = new Validator();
            if(tester3.IsValidFirstname(value))
            {
                _firstname = value;
            };
        }
    }
    public string Lastname
    {
        get
        {
            return _lastname;
        }
        set
        {
            Validator tester4 = new Validator();
            if(tester4.IsValidLastname(value))
            {
                _lastname = value;
            };
        }
    }
    public string DateOfBirth
    {
        get
        {
            return _dateofbirth;
        }
        set
        {
            Validator tester5 = new Validator();
            if(tester5.IsValidBirthdate(value))
            {
                _dateofbirth = value;
            };
        }
    }
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            Validator tester6 = new Validator();
            if(tester6.IsValidAge(value))
            {
                _age = value;
            };
        }
    }
};

static class Program
{
    static void Main(string[] args)
    {
        Person NewUser1 = new Person();

        Console.Write("Set your username: ");
        NewUser1.Username = Console.ReadLine();

        Console.Write("Set your password: ");
        NewUser1.Password = Console.ReadLine();

        Console.Write("Your firstname: ");
        NewUser1.Firstname = Console.ReadLine();

        Console.Write("Your lastname: ");
        NewUser1.Lastname = Console.ReadLine();

        Console.Write("Date of birth (YYYY-MM-DD): ");
        NewUser1.DateOfBirth = Console.ReadLine();

        Console.Write("Your age: ");
        NewUser1.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("----------------------\nResult:");
        Console.WriteLine("Username: " + NewUser1.Username);
        Console.WriteLine("Password: " + NewUser1.Password);
        Console.WriteLine("Firstname: " + NewUser1.Firstname);
        Console.WriteLine("Lastname: " + NewUser1.Lastname);
        Console.WriteLine("DateOfBirth: " + NewUser1.DateOfBirth);
        Console.WriteLine("Age: " + NewUser1.Age);
    }
};
