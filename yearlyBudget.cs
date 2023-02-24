namespace Bank;

public class Budget
{

	public List<User> UsersList { get; set; }

	public List<Transaction> TransactionsList { get; set; }

	public Budget(List<User> ourUserList, List<Transaction> ourTransactionList)
	{
		UsersList = ourUserList;
		TransactionsList = ourTransactionList;

	}
	public void CalculateBalanceAllUsers()
	{
		//should write "  ... Name of user: how much they owe/owed
		foreach (User user in UsersList)
		{
			decimal balance = 0;

			foreach (Transaction transaction in TransactionsList)
			{
				if (user.Name == transaction.FromAccount.Name)
				{
					balance += transaction.Amount;
				}

				if (user.Name == transaction.ToAccount.Name)
				{
					balance -= transaction.Amount;
				}
			}
			Console.WriteLine($"{user.Name} net balance: {balance}");
		}
	}

	public void GetPersonalTransactions()
	{
		int transactionCount = 0;
		Console.WriteLine("Select a user to view transactions");
		string response = Console.ReadLine();
		if (UsersList.Any(a => a.Name == response))
		{
			foreach (var transaction in TransactionsList)
			{
				if (response == transaction.ToAccount.Name || response == transaction.FromAccount.Name)
				{
					transactionCount += 1;
					Console.WriteLine($"#{transactionCount}: Date: {transaction.Date} From: {transaction.FromAccount.Name} To: {transaction.ToAccount.Name} Details: {transaction.Narrative} Amount: {transaction.Amount}");
				}
			}
		}
		else
		{
			Console.WriteLine("Error - no user found");

		}
	}
}

// 			if (!usersList.Any(a => a.Name == uniqueTransaction.To.Name))
