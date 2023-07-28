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

		public decimal Balance { get; }

		// static as it will be shared by all bankAccount objects
		private static int accountNumberSeed = 1234567890;

		private List<Transaction> allTransaction = new List<Transaction>();

		//creating a object(constructor) for bank account class to assign those values
		public BankAccount(string name, decimal intialBalance)
		{
			this.Owner = name;
			this.Balance = intialBalance;
			this.Number = accountNumberSeed.ToString();
			accountNumberSeed++;

		}

		public void MakeDeposit(decimal amount, DateTime date, string note)
		{

		}

		public void MakeWithdrawal(decimal amount, DateTime date, string note)
		{

		}
	}
}
