using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
	public class BankAccount
	{
		public string Number { get; }

		public string Owner { get; set; }

		public decimal Balance { get
			{ 
				decimal balance = 0;
				foreach(var item in allTransaction)
				{
					balance += item.Amount;
				}
				return balance;
			
			} 
		}

		// static as it will be shared by all bankAccount objects
		private static int accountNumberSeed = 1234567890;

		private List<Transaction> allTransaction = new List<Transaction>();

		//creating a object(constructor) for bank account class to assign those values
		public BankAccount(string name, decimal intialBalance)
		{
			this.Owner = name;
			MakeDeposit(intialBalance, DateTime.Now, "Initial balance");
			this.Number = accountNumberSeed.ToString();
			accountNumberSeed++;

		}

		public void MakeDeposit(decimal amount, DateTime date, string note)
		{
			if(amount <= 0)
			{
				throw new ArgumentOutOfRangeException (nameof(amount), "Amount of deposit must be positive");
			}
			var deposit = new Transaction(amount, date, note);
			allTransaction.Add(deposit);
		}

		public void MakeWithdrawal(decimal amount, DateTime date, string note)
		{
			if (amount <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
			}
			if(Balance - amount < 0)
			{
				throw new InvalidOperationException("Insufficient funds for this withdrawal");
			}
			var withdrawal = new Transaction(-amount, date, note);
			allTransaction.Add(withdrawal);

		}
	}
}
