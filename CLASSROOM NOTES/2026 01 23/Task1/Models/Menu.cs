namespace RestourantModels;

public static class Menu
{
    #region MAIN MENU
    public static void ShowMainMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Admin                       ►");
        Console.WriteLine("  2) Manager                     ►");
        Console.WriteLine("  3) User                        ►");
        Console.WriteLine("  0) Close                       •");
        Console.WriteLine("————————————————————————————————————————————————");
    }
    #endregion

    #region ADMIN
    public static void ShowAdminMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / ADMIN PANEL");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Show Balance                •");
        Console.WriteLine("  2) Organize Managers           ►");
        Console.WriteLine("  3) Organize Employees          ►");
        Console.WriteLine("  0) Logout                      ◄");
        Console.WriteLine("————————————————————————————————————————————————");
    }
    public static void ShowAdminManagersMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / ADMIN PANEL / MANAGERS");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Show All Employees          •");
        Console.WriteLine("  2) Show Employees Information  •");
        Console.WriteLine("  3) Add new Employee            •");
        Console.WriteLine("  4) Remove Employee             •");
        Console.WriteLine("  0) Go Back                     ◄");
        Console.WriteLine("————————————————————————————————————————————————");
    }
    public static void ShowAdminEmployeesMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / ADMIN PANEL / EMPLOYEES");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Show All Managers           •");
        Console.WriteLine("  2) Show Manager Information    •");
        Console.WriteLine("  3) Assign a Manager            •");
        Console.WriteLine("  4) Remove Manager              •");
        Console.WriteLine("  0) Go Back                     ◄");
        Console.WriteLine("————————————————————————————————————————————————");
    }
    #endregion

    #region MANAGER
    public static void ShowManagerMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / MANAGER PANEL");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Change Table Status         •");
        Console.WriteLine("  0) Go Back                     ◄");
        Console.WriteLine("————————————————————————————————————————————————");
    }
    #endregion

    #region USER
    public static void ShowUserMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / MAIN MENU");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Make Reservation            •");
        Console.WriteLine("  0) Go Back                     ◄");
        Console.WriteLine("————————————————————————————————————————————————");
    }
    #endregion

    #region INPUT
    public static string ReadMenuInput()
    {
        Console.Write("■ Choose: ");
        return Console.ReadLine();
    }
    #endregion
}
