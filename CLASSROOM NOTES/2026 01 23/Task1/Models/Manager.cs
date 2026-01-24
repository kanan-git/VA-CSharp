namespace RestourantModels;

public class Manager:Person
{
    public Guid Id = Guid.NewGuid();
    public string Username {get; set;}
    public string Password {get; set;}
    
    public void ChangeTableStatus()
    {}
}
