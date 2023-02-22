namespace Bank;
public class Transaction
{
	public string Date { get; set; }
	public string From { get; set; }
	public string To { get; set; }
	public string Details { get; set; }
	public decimal Amount { get; set; }

//constructor
	public Transaction (string date, string from, string to, string details, decimal amount ) 
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