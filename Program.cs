using MySuperBank;

internal class Program
{
	private static void Main(string[] args)
	{
		//creating a bank account object by calling the constructor.
		var account = new BankAccount("Kendra", 10000);
		Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
	}
} 