namespace Bank;
using NLog;
using System.Text.Json;
using Newtonsoft.Json;


//class of yearlyBudget -
// list of all transactions and all accounts
// the methods e.g. below to populate those lists; 

public class CSVReader
{
	private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

	public Budget GetTransactionDetails(string path)
	{

		List<User> usersList = new List<User>();

		string[] lines = System.IO.File.ReadAllLines(path);

		List<Transaction> allTransactions = new List<Transaction>();
		int rowCounter = 1;
		foreach (string line in lines.Skip(1))
		{
			rowCounter++;
			string[] rows = line.Split(',');
			DateTime date = new DateTime();
			try
			{
				date = DateTime.Parse(rows[0]);
			}
			catch (System.FormatException exception)
			{
				Console.WriteLine($"Error on row {rowCounter}. The date provided is not in the correct format");
				throw exception;
			}
			User ToUser = new User(Convert.ToString(rows[1]));
			User FromUser = new User(Convert.ToString(rows[2]));
			string details = rows[3];
			decimal amount;

			try
			{
				amount = decimal.Parse(rows[4]);
			}
			catch (System.FormatException exception)
			{
				Logger.Error($"Fatal error on row {rowCounter}!.: The amount must be entered as a decimal number");
				Console.WriteLine($"Error on row {rowCounter}!. The amount must be entered as a decimal number");
				throw exception;
			}
			Transaction uniqueTransaction = new Transaction(date, ToUser, FromUser, details, amount);
			allTransactions.Add(uniqueTransaction);

			//Example of a Transaction: [Date, {Name: (string) name }, {Name:name}, Narrative, Amount  ]

			if (!usersList.Any(a => a.Name == uniqueTransaction.ToAccount.Name))
				usersList.Add(uniqueTransaction.ToAccount);

			//Example of UsersList: [{Name: name}, {Name: name}, {Name: name}]
			Logger.Info($"Line {rowCounter} completed successfully");
		}

		return new Budget(usersList, allTransactions);
	}

	public void getJSONTransactionDetails(string path)
	{
		string lines = System.IO.File.ReadAllText(path);
		
			var jsonData = JsonConvert.DeserializeObject<List<Transaction>>(lines);
			Console.WriteLine(jsonData);
	
	}
}

//Pairing transactions with users for ListAll Method; 
//We have two lists - a <list>Transactions and a list<Accounts> 
//Loop through our list of accounts - i.e all the unique in the DB
//create a variable -e.g. 'total owe/owed'
// For each person, loop through the transactions list - 
// if they're in 'Person to' : - the amount : in personFrom + the amount; 
