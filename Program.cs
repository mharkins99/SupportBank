using Bank;
using NLog;
using NLog.Config;
using NLog.Targets;

var config = new LoggingConfiguration();
var target = new FileTarget { FileName = @"C:\Work\Logs\SupportBank.log", Layout = @"${longdate} ${level} - ${logger}: ${message}" };
config.AddTarget("File Logger", target);
config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, target));
LogManager.Configuration = config;

//Class Budget: 
//List<Transactions> 
//List<User>
//Method: ListAll
//Method: ListAccount(takes an User instance)* {loops through transactions and Console.WriteLines any transaction with their name in either to/from }
//CONSTRUCTOR (*string for the excel filepath*) {
//Run all the stuff you've got in CSVReader
// }

//Program.CS:
//Budget Budget2014 = new Budget(*filepath*)


//Class User

//Class Transaction

CSVReader csvReader = new CSVReader();

Budget Budget2014 = csvReader.GetTransactionDetails("transactions2014.csv");

Budget Budget2015 = csvReader.GetTransactionDetails("Transactions2015.csv");

Console.WriteLine("See all users (1) \n all transactions for individual user (2)");
string userOption = Console.ReadLine();

if (userOption == "1")
{
	Budget2015.CalculateBalanceAllUsers();
}
else if (userOption == "2")
{
    Budget2015.GetPersonalTransactions();
}

else { Console.WriteLine("ERROR!"); }

// foreach (Transaction transaction in transactions) {

// Console.WriteLine(transaction.Amount);
//}

//Budget budgetFor2014: new Budget("*stringforCSVfilepath*"); 
//bugetFor2014.ListAll(); 

/*List<string> users = new transactions.to.Distinct();

foreach(Transaction user in users) {
    Console.WriteLine(user);
}
*/