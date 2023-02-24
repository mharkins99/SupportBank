namespace Bank;
public class Transaction
{
	public DateTime Date { get; set; }
	public User FromAccount { get; set; }
	public User ToAccount { get; set; }
	public string Narrative { get; set; }
	public decimal Amount { get; set; }

//constructor
	public Transaction (DateTime date, User from, User to, string details, decimal amount ) 
	//lowercase indicates parameter, value to vary with individual instances
	//capitals indicate data fields/properties
	{
		Date = date;
		FromAccount = from;
		ToAccount = to;
		Narrative = details;
		Amount = amount;
	}

//method
}