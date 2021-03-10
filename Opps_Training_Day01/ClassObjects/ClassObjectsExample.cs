using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Day01.ClassObjects
{
	public class ClassObjectsExample
	{
		public int EmployeeNumber { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Address1 { get; set; }

		public string Address2 { get; set; }

		public string City { get; set; }

		public int PinCode { get; set; }

		public string State { get; set; }

		public void DisplayName()
		{
			Console.WriteLine("Employee Name" + this.FirstName + "" + this.LastName);
		}
	}
}
