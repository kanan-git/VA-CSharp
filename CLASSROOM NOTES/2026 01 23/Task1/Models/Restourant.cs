namespace RestourantModels;

public static class Restourant
{
    public static Manager ActiveManager = null;
    public static List<Table> AllTablesList = new List<Table>(0);

    public static void ShowAllTables()
    {
        if(AllTablesList.Count > 0)
        {
            Console.WriteLine("Available Tables:\n---------------------------");
            foreach(Table table in AllTablesList)
            {
                Console.Write(table.Id + ", ");
            }
        }
        else
        {
            Console.WriteLine("No table found.");
        }
    }
    public static void ShowAvailableTables()
    {
        bool HaveAvailableTable = false;
        if(AllTablesList.Count > 0)
        {
            Console.WriteLine("Available Tables:\n---------------------------");
            foreach(Table table in AllTablesList)
            {
                if(!HaveAvailableTable)
                {
                    HaveAvailableTable = true;
                }

                if(table.IsAvailable)
                {
                    Console.Write(table.Id + ", ");
                }
            }

            if(!HaveAvailableTable)
            {
                Console.WriteLine("Oops. All tables are reserved. Try again later.");
            }
        }
        else
        {
            Console.WriteLine("No table found.");
        }
    }
}
