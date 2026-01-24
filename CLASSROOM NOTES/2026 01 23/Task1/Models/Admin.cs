using System.Text;
using CustomExceptions;

namespace RestourantModels;

public static class Admin
{
    #region VALUES
    private static string _password = "123";
    private static double _balance = 0;
    public static List<Manager> AllManagersList = new List<Manager>(0);
    public static List<Employee> AllEmployeesList = new List<Employee>(0);
    #endregion

    #region ACCOUNT
    public static void VerifyPassword(string input)
    {
        if(input != _password)
        {
            throw new WrongPasswordException();
        }
    }
    public static double CheckBalance()
    {
        return _balance;
    }
    public static void Deposit(double amount)
    {
        _balance += amount;
    }
    public static void Withdraw(double amount)
    {
        try
        {
            _balance -= amount;
        }
        catch(InsufficientBalanceException)
        {
            throw;
        }
    }
    #endregion

    #region MANAGER
    public static void ShowManagers()
    {
        if(AllManagersList.Count > 0)
        {
            int index = 0;
            string result = "";
            StringBuilder ManagersString = new StringBuilder();
            foreach(Manager manager in AllManagersList)
            {
                index++;
                ManagersString.Append($"#{index}) {manager.FirstName}");
            }
            result += $"List of Managers ({index}):\n-----------------------";
            result += ManagersString.ToString();
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("List of Managers (0):\n-----------------------");
            Console.WriteLine("No Manager Found.");
        }
    }
    public static void ManagerDetails()
    {
        if(AllManagersList.Count > 0)
        {
            Console.WriteLine("Select Managers:\n-----------------------");
            for(int i=0; i<AllManagersList.Count; i++)
            {
                Console.WriteLine($"#{i+1}) {AllManagersList[i].FirstName}");
            }
        }
        string selection = Menu.ReadMenuInput();
        try
        {
            Manager SelectedManager = AllManagersList[int.Parse(selection)-1];
            Console.WriteLine($"Defails of Selected #{selection} Manager");
            Console.WriteLine($"ID: {SelectedManager.Id}\nFirst Name: {SelectedManager.FirstName}\nLast Name: {SelectedManager.LastName}\nUsername: {SelectedManager.Username}\nPassword: {SelectedManager.Password}");
        }
        catch(InvalidMenuInputException)
        {
            throw new InvalidMenuException();
        }
        catch(Exception)
        {
            throw;
        }
        finally
        {
            return;
        }
    }
    public static void AddManager()
    {
        try
        {
            Manager NewManager = new Manager();

            Console.Write("Enter First Name: ");
            NewManager.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            NewManager.LastName = Console.ReadLine();
            Console.Write("Set username: ");
            NewManager.Username = Console.ReadLine();
            Console.Write("Set Password: ");
            NewManager.Password = Console.ReadLine();

            AllManagersList.Add(NewManagerw);

            Console.WriteLine("New Manager successfully created.");
        }
        catch(Exception)
        {
            throw;
        }
    }
    public static void RemoveManager()
    {
        Console.WriteLine("Enter Managers Id:\n-----------------------");
        try
        {
            if(AllManagersList.Count > 0)
            {
                Console.Write("ID: ");
                Guid InputSelection = new Guid(Console.ReadLine());
                foreach(Manager manager in AllManagersList)
                {
                    if(manager.Id == InputSelection)
                    {
                        AllManagersList.Remove(manager);
                        return;
                    }
                }
                Console.WriteLine("No Match Found.");
            }
            else
            {
                Console.WriteLine("Empty List. There is no assigned Manager.");
            }
        }
        catch(IncorrectIdException)
        {
            throw new IncorrectIdException();
        }
    }
    #endregion

    #region EMPLOYEES
    public static void ShowEmployees()
    {
        if(AllEmployeesList.Count > 0)
        {
            int index = 0;
            string result = "";
            StringBuilder EmployeesString = new StringBuilder();
            foreach(Employee employee in AllEmployeesList)
            {
                index++;
                EmployeesString.Append($"#{index}) {employee.FirstName}");
            }
            result += $"List of Employees ({index}):\n-----------------------";
            result += EmployeesString.ToString();
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("List of Employees (0):\n-----------------------");
            Console.WriteLine("No Manager Found.");
        }
    }
    public static void EmployeeDetails()
    {
        if(AllEmployeesList.Count > 0)
        {
            Console.WriteLine("Select Employee:\n-----------------------");
            for(int i=0; i<AllEmployeesList.Count; i++)
            {
                Console.WriteLine($"#{i+1}) {AllEmployeesList[i].FirstName}");
            }
        }
        string selection = Menu.ReadMenuInput();
        try
        {
            Employee SelectedEmployee = AllEmployeesList[int.Parse(selection)-1];
            Console.WriteLine($"Defails of Selected #{selection} Employee");
            Console.WriteLine($"ID: {SelectedEmployee.Id}\nFirst Name: {SelectedEmployee.FirstName}\nLast Name: {SelectedEmployee.LastName}\nUsername: {SelectedEmployee.Username}\nPassword: {SelectedEmployee.Password}");
        }
        catch(InvalidMenuInputException)
        {
            throw new InvalidMenuException();
        }
        catch(Exception)
        {
            throw;
        }
        finally
        {
            return;
        }
    }
    public static void AddEmployee()
    {
        try
        {
            Employee NewEmployee = new Employee();

            Console.Write("Enter First Name: ");
            NewEmployee.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            NewEmployee.LastName = Console.ReadLine();

            AllEmployeesList.Add(NewEmployee);

            Console.WriteLine("New Employee successfully created.");
        }
        catch(Exception)
        {
            throw;
        }
    }
    public static void RemoveEmployee()
    {
        Console.WriteLine("Enter Employees Id:\n-----------------------");
        try
        {
            if(AllEmployeesList.Count > 0)
            {
                Console.Write("ID: ");
                Guid InputSelection = new Guid(Console.ReadLine());
                foreach(Employee employee in AllEmployeesList)
                {
                    if(employee.Id == InputSelection)
                    {
                        AllEmployeesList.Remove(employee);
                        return;
                    }
                }
                Console.WriteLine("No Match Found.");
            }
            else
            {
                Console.WriteLine("Empty List. There is no Employees.");
            }
        }
        catch(IncorrectIdException)
        {
            throw new IncorrectIdException();
        }
    }
    #endregion
}
