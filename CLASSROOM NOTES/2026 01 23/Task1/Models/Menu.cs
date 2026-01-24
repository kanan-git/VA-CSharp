namespace RestourantModels;

public class Menu
{
    public void ShowMainMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Admin                       ►");
        Console.WriteLine("  2) Manager                     ►");
        Console.WriteLine("  3) User                        ►");
        Console.WriteLine("  0) Close                       •");
    }
    public void ShowAdminMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / ADMIN PANEL");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Show Balance                •");
        Console.WriteLine("  2) Organize Managers           ►");
        Console.WriteLine("  3) Organize Employees          ►");
        Console.WriteLine("  0) Logout                      ◄");
    }
    public void ShowAdminManagersMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / ADMIN PANEL / MANAGERS");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Show All Employees          •");
        Console.WriteLine("  2) Show Employees Information  ►");
        Console.WriteLine("  3) Add new Employee            ►");
        Console.WriteLine("  4) Remove Employee             ►");
        Console.WriteLine("  0) Go Back                     ◄");
    }
    public void ShowAdminEmployeesMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / ADMIN PANEL / EMPLOYEES");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Show All Managers           •");
        Console.WriteLine("  2) Show Manager Information    ►");
        Console.WriteLine("  3) Assign a Manager            ►");
        Console.WriteLine("  4) Remove Manager              ►");
        Console.WriteLine("  0) Go Back                     ◄");
    }
    public void ShowManagerMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / MANAGER PANEL");
        Console.WriteLine("————————————————————————————————————————————————");
        // Console.WriteLine("  1) Show Balance                •");
        // Console.WriteLine("  2) Organize Managers           ►");
        // Console.WriteLine("  3) Organize Employees          ►");
        Console.WriteLine("  0) Logout                      ◄");
    }
    public void ShowUserMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / MAIN MENU");
        Console.WriteLine("————————————————————————————————————————————————");
        // Console.WriteLine("  1) Show Balance                •");
        // Console.WriteLine("  2) Organize Managers           ►");
        // Console.WriteLine("  3) Organize Employees          ►");
        Console.WriteLine("  0) Logout                      ◄");
    }
    public string ReadMenuInput()
    {
        Console.Write("■ Choose: ");
        return Console.ReadLine();
    }
}
