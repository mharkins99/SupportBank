namespace Bank;

//class of yearlyBudget -
// list of all transactions and all accounts
// the methods e.g. below to populate those lists; 

public class CSVReader
{
    
    public List<Transaction> GetTransactionDetails()
    {
        List<User> usersList = new List<User>(); 

        string path = @"C:\Users\michar\OneDrive - Softwire Technology Limited\Desktop\Transactions2014.csv";

        string[] lines = System.IO.File.ReadAllLines(path);

        List<Transaction> allTransactions = new List<Transaction>();
        foreach (string line in lines.Skip(1))
        {
            string[] rows = line.Split(',');
            string date = rows[0];
            User ToUser = new User(Convert.ToString(rows[1]));
            User FromUser = new User(Convert.ToString(rows[2]));
            string details = rows[3];
            decimal amount = decimal.Parse(rows[4]);

            Transaction uniqueTransaction = new Transaction(date, ToUser, FromUser, details, amount);
            allTransactions.Add(uniqueTransaction);

            //Example of a Transaction: [Date, {Name: (string) name }, {Name:name}, Narrative, Amount  ]

            if (!usersList.Any(a => a.Name == uniqueTransaction.To.Name))
                usersList.Add(uniqueTransaction.To);
            
        //Example of UsersList: [{Name: name}, {Name: name}, {Name: name}]

        }
        foreach (var item in usersList)
        {
            Console.WriteLine(item.Name);    
        }
        
        return allTransactions;
    }
}



//Pairing transactions with users for ListAll Method; 
//We have two lists - a <list>Transactions and a list<Accounts> 
//Loop through our list of accounts - i.e all the unique in the DB
//create a variable -e.g. 'total owe/owed'
// For each person, loop through the transactions list - 
// if they're in 'Person to' : - the amount : in personFrom + the amount; 
