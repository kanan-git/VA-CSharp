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
        Menu.ShowMainMenu();
    }
}
