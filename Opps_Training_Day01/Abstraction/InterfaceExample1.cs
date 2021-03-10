using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Day01.Abstraction
{
	//https://www.c-sharpcorner.com/article/use-of-interface-with-real-time-examples-interview-questions-and-answers-about/

	public interface ISavingAccount
	{
		void PrintAccountData();
	}

	public interface ICurrentAccount
	{
		void PrintAccountData();
	}

	public class Account : ISavingAccount, ICurrentAccount
	{
		void ISavingAccount.PrintAccountData()
		{
			Console.WriteLine("Saving account data.");
		}

		void ICurrentAccount.PrintAccountData()
		{
			Console.WriteLine("Current account data.");
		}
	}
}
