using Bank;


CSVReader csvReader = new CSVReader(); 
List<Transaction> transactions = csvReader.GetTransactionDetails();

List<string> users = new transactions.to.Distinct();

foreach(Transaction user in users) {
    Console.WriteLine(user);
}