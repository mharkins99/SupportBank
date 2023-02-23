namespace Bank;
public class User
{
    public string Name {get; set; }
    // public List<Transaction> Outgoing { get; set; }
    // public List<Transaction> Incoming { get; set; }
        
    public User (string name) 
    {
        Name = name;
        // Outgoing = new List<Transaction>();
        // Incoming = new List<Transaction>();

    }

}
                        
