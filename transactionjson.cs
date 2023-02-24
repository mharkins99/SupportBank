namespace Bank;
public class Transactionjson
{
	public DateTime Date { get; set; }
	public string FromAccount { get; set; }
	public string ToAccount { get; set; }
	public string Narrative { get; set; }
	public decimal Amount { get; set; }

//constructor
	public Transactionjson (DateTime date, string from, string to, string details, decimal amount ) 
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