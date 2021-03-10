using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Day01.Abstraction
{
	public abstract class Employee
	{
		public abstract int GetSalary();

		//public Guid GetEmployeeNumber()
		//{
		//	return Guid.NewGuid();
		//}
	}

	// class 'Employee' inherit 
	// in child class 'Developer' 
	class Developer : Employee
	{
		private int salary;
		public Developer(int s)
		{
			this.salary = s;
		}

		// abstract method 'GetSalary()' 
		// declare here with 
		// 'override' keyword 
		public override int GetSalary()
		{
			return this.salary;
		}
	}

	// class 'Employee' inherit 
	// in child class 'Driver' 
	class Driver : Employee
	{
		private readonly int salary;
		public Driver(int s)
		{
			this.salary = s;
		}

		// abstract method 'GetSalary()' 
		// declare here with 
		// 'override' keyword 
		public override int GetSalary()
		{
			return this.salary;
		}

		//public int GetEmployeeNumber()
		//{
		//	var guid = base.GetEmployeeNumber();
		//}
	}
}
