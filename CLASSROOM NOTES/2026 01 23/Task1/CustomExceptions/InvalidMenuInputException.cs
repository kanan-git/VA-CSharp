namespace CustomExceptions;

public class InvalidMenuInputException:Exception
{
    public InvalidMenuInputException():base()
    {
        Console.WriteLine("Out of range, try related numbers from menu.");
    }
}
