namespace CustomExceptions;

public class WrongPasswordException:Exception
{
    public WrongPasswordException():base()
    {
        Console.WriteLine("Password isn't correct!");
    }
}
