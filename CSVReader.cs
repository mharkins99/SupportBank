namespace Bank;

public class CSVReader
{
    public List<Transaction> GetTransactionDetails()
    {
        string path = @"C:\Users\michar\OneDrive - Softwire Technology Limited\Desktop\Transactions2014.csv";

        string[] lines = System.IO.File.ReadAllLines(path);

        List<Transaction> allTransactions = new List<Transaction>();
        foreach (string line in lines.Skip(1))
        {
            string[] rows = line.Split(',');
            string date = rows[0]; // date
            string to = rows[1]; // to
            string from = rows[2]; // from
            string details = rows[3]; // narrative
            decimal amount = decimal.Parse(rows[4]); // amount


            Transaction uniqueTransaction = new Transaction(date, to, from, details, amount);
            allTransactions.Add(uniqueTransaction);
        }
		return allTransactions;
    }
}
