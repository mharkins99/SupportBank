namespace Bank;
public class Transaction
{
	public string Date { get; set; }
	public User From { get; set; }
	public User To { get; set; }
	public string Details { get; set; }
	public decimal Amount { get; set; }

//constructor
	public Transaction (string date, User from, User to, string details, decimal amount ) 
	//lowercase indicates parameter, value to vary with individual instances
	//capitals indicate data fields/properties
	{
		Date = date;
		From = from;
		To = to;
		Details = details;
		Amount = amount;
	}

//method
}