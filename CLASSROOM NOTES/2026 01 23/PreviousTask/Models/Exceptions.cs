namespace Errors;

public class BookNotFoundException:Exception
{
    // public BookNotFoundException():base()
    public BookNotFoundException()
    {
        Console.WriteLine("Book not found.");
    }
}
public class UserNotFoundException:Exception
{
    public UserNotFoundException()
    {
        Console.WriteLine("User not found.");
    }
}
public class CustomInvalidOperationException:Exception
{
    public CustomInvalidOperationException()
    {
        Console.WriteLine("This book already rented.");
    }
}
