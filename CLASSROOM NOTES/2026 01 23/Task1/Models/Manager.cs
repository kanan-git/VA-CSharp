namespace RestourantModels;

public class Manager:Person
{
    #region VALUES
    public Guid Id = Guid.NewGuid();
    public string Username {get; set;}
    public string Password {get; set;}
    #endregion

    #region ACCOUNT
    public static void Authentication()
    {
        if(InputUsername != Username || InputPassword != Password)
        {
            throw new Exception("Invalid Credentials.");
        }
        Console.WriteLine($"Welcome {this.FirstName} {this.LastName}.");
    }
    #endregion
    
    #region TABLES
    public void AddNewTable()
    {
        Table NewTable = new Table();
        Console.Write("Assign number to the table: ");
        int NewTableId = int.Parse(Console.ReadLine());
        Table.Id = NewTableId;
        Restourant.AllTablesList.Add(NewTable);
        Console.WriteLine("New Table successfully added.");
    }
    public void RemoveTable(int TableId)
    {
        foreach(Table table in Restourant.AllTablesList)
        {
            if(table.Id == TableId)
            {
                Restourant.AllTablesList.Remove(table);
                Console.WriteLine($"Table #{TableId} removed.");
                break;
            }
        }
        Console.WriteLine("Table not found.");
    }
    public void ChangeTableStatus(int TableId, bool TableStatus)
    {
        foreach(Table table in Restourant.AllTablesList)
        {
            if(table.Id == TableId)
            {
                if(TableStatus)
                {
                    table.IsAvailable = true;
                    Console.WriteLine($"Table #{TableId} is available now.");
                }
                else
                {
                    table.IsAvailable = false;
                    Console.WriteLine($"Table #{TableId} successfully reserved.");
                    break;
                }
            }
        }
        Console.WriteLine("Table not found.");
    }
    #endregion
}
