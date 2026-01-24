namespace RestourantModels;

public static class Admin
{
    #region VALUES
    private static string Password = "123";
    private static double Balance {get; set;}
    private static List<Manager> AllManagersList = new List<Manager>(0);
    private static List<Employee> AllEmployeesList = new List<Employee>(0);
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
    public static void EmployeesDetails()
    {}
    public static void AddEmployees()
    {}
    public static void RemoveEmployees()
    {}
    #endregion
}
