namespace CustomExceptions;

public class IncorrectIdException:Exception
{
    public IncorrectIdException():base()
    {
        Console.WriteLine("Incorrect ID");
    }
}
