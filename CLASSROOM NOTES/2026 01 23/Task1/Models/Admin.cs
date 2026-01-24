using CustomExceptions;

namespace RestourantModels;

public static class Admin
{
    #region FIELDS
    private static string _password = "123";
    private static double _balance = 0;
    public static List<Manager> AllManagersList = new List<Manager>(0);
    public static List<Employee> AllEmployeesList = new List<Employee>(0);
    #endregion

    #region PROPERTIES
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
    {}
    public static void ManagerDetails()
    {}
    public static void AddManager()
    {}
    public static void RemoveManager()
    {}
    #endregion

    #region EMPLOYEES
    public static void ShowEmployees()
    {}
    public static void EmployeeDetails()
    {}
    public static void AddEmployee()
    {}
    public static void RemoveEmployee()
    {}
    #endregion
}
