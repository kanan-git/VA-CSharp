using RestourantModels;
using RestourantInterfaces;
using CustomExceptions;

internal static class Program
{
    internal static void Main(string[] args)
    {
        Application();
    }

    internal static void Application()
    {
        while(true)
        {
            Menu.ShowMainMenu();
            string selection = Menu.ReadMenuInput();
            switch (selection)
            {
                case "1":
                    Menu.OpenAdminMenu();
                    break;
                case "2":
                    Menu.OpenManagerMenu();
                    break;
                case "3":
                    Menu.OpenUserMenu();
                    break;
                case "0":
                    Console.WriteLine("Application has been closed.");
                    return;
                default:
                    throw new InvalidMenuInputException();
            }
        }
    }
}
