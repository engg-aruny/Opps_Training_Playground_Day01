using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Day01.Abstraction
{
	interface IInterface1
	{
		// method having only declaration  
		// not definition 
		void display();
	}

	// A class that implements interface. 
	class TestClass : IInterface1
	{

		// providing the body part of function 
		public void display()
		{
			Console.WriteLine("Sudo Placement GeeksforGeeks");
		}
	}
}
