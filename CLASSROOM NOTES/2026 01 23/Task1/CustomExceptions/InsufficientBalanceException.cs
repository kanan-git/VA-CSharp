namespace CustomExceptions;

public class InsufficientBalanceException:Exception
{
    public InsufficientBalanceException():base()
    {
        Console.WriteLine("There is not enough balance.");
    }
}
