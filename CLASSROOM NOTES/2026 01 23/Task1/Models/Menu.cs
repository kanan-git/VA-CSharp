// using System.Security.Authentication;
using CustomExceptions;

namespace RestourantModels;

public static class Menu
{
    #region MAIN MENU
    public static void ShowMainMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Admin                                     ►");
        Console.WriteLine("  2) Manager                                   ►");
        Console.WriteLine("  3) User                                      ►");
        Console.WriteLine("  0) Close                                     •");
        Console.WriteLine("————————————————————————————————————————————————");
    }
    #endregion

    #region ADMIN
    public static void OpenAdminMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / ADMIN PANEL");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Show Balance                              •");
        Console.WriteLine("  2) Organize Managers                         ►");
        Console.WriteLine("  3) Organize Employees                        ►");
        Console.WriteLine("  0) Logout                                    ◄");
        Console.WriteLine("————————————————————————————————————————————————");

        string selection = ReadMenuInput();
        switch (selection)
        {
            case "1":
                string BalanceMessage = $"Current Balance: {Admin.CheckBalance()}";
                Console.WriteLine(BalanceMessage);
                break;
            case "2":
                OpenAdminManagersMenu();
                break;
            case "3":
                OpenAdminEmployeesMenu();
                break;
            case "0":
                return;
            default:
                throw new InvalidMenuInputException();
        }
    }
    public static void OpenAdminManagersMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / ADMIN PANEL / MANAGERS");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Show All Managers                         •");
        Console.WriteLine("  2) Show Manager Information                  •");
        Console.WriteLine("  3) Add new Manager                           •");
        Console.WriteLine("  4) Remove Manager                            •");
        Console.WriteLine("  0) Go Back                                   ◄");
        Console.WriteLine("————————————————————————————————————————————————");

        string selection = ReadMenuInput();
        switch (selection)
        {
            case "1":
                Admin.ShowManagers();
                break;
            case "2":
                Admin.ManagerDetails();
                break;
            case "3":
                Admin.AddManager();
                break;
            case "4":
                Admin.RemoveManager();
                break;
            case "0":
                return;
            default:
                throw new InvalidMenuInputException();
        }
    }
    public static void OpenAdminEmployeesMenu()
    {
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / ADMIN PANEL / EMPLOYEES");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Show All Employees                        •");
        Console.WriteLine("  2) Show Employee Information                 •");
        Console.WriteLine("  3) Assign a Employee                         •");
        Console.WriteLine("  4) Remove Employee                           •");
        Console.WriteLine("  0) Go Back                                   ◄");
        Console.WriteLine("————————————————————————————————————————————————");

        string selection = ReadMenuInput();
        switch (selection)
        {
            case "1":
                Admin.ShowEmployees();
                break;
            case "2":
                Admin.EmployeeDetails();
                break;
            case "3":
                Admin.AddEmployee();
                break;
            case "4":
                Admin.RemoveEmployee();
                break;
            case "0":
                return;
            default:
                throw new InvalidMenuInputException();
        }
    }
    #endregion

    #region MANAGER
    public static void OpenManagerMenu()
    {
        Manager? SelectedManager = null;

        if(Admin.AllManagersList.Count)
        {
            Console.Write("Enter Username");
            string InputUsername = Console.ReadLine();
            Console.Write("Enter Password");
            string InputPassword = Console.ReadLine();

            foreach(Manager manager in Admin.AllManagersList)
            {
                if(manager.Username == InputUsername)
                {
                    if(manager.Password == InputPassword)
                    {
                        SelectedManager = manager;
                        Restourant.ActiveManager = manager;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }

            if(SelectedManager == null)
            {
                Console.WriteLine("Invalid Credentials! Try Again.");
                return;
            }
        }
        else
        {
            Console.WriteLine("No Manager Found.");
            return;
        }

        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / MANAGER PANEL");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Add new Table                             •");
        Console.WriteLine("  2) Remove Table                              •");
        Console.WriteLine("  3) Change Table Status                       •");
        Console.WriteLine("  0) Go Back                                   ◄");
        Console.WriteLine("————————————————————————————————————————————————");

        string selection = ReadMenuInput();
        switch (selection)
        {
            case "1":
                SelectedManager.AddNewTable();
                break;
            case "2":
                Console.Write("Enter table number to remove: ");
                int SelectedTableId = int.Parse(Console.ReadLine());
                SelectedManager.RemoveTable(SelectedTableId);
                break;
            case "3":
                Console.Write("Enter table number: ");
                int SelectedTableId = int.Parse(Console.ReadLine());
                bool SelectedTableStatus = bool.Parse(Console.ReadLine());
                SelectedManager.ChangeTableStatus(TableId:SelectedTableId, TableStatus:SelectedTableStatus);
                break;
            case "0":
                return;
            default:
                throw new InvalidMenuInputException();
        }
    }
    #endregion

    #region USER
    public static void OpenUserMenu()
    {
        if(Restourant.ActiveManager == null)
        {
            Console.WriteLine("Sorry. Restourant is closed now. Try later.");
            return;
        }

        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  RESTOURANT / MAIN MENU");
        Console.WriteLine("————————————————————————————————————————————————");
        Console.WriteLine("  1) Make Reservation                          •");
        Console.WriteLine("  0) Go Back                                   ◄");
        Console.WriteLine("————————————————————————————————————————————————");

        string selection = ReadMenuInput();
        switch (selection)
        {
            case "1":
                Client NewClient = new Client();

                Console.Write("Your First Name: ");
                NewClient.FirstName = Console.ReadLine();
                Console.Write("Your Last Name: ");
                NewClient.LastName = Console.ReadLine();

                Restourant.ShowAvailableTables();

                Console.Write("Select Table");
                int TableSelection = int.Parse(Console.ReadLine());

                Restourant.ActiveManager.ChangeTableStatus(TableId: TableSelection, TableStatus: false);
                break;
            case "0":
                return;
            default:
                throw new InvalidMenuInputException();
        }
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
