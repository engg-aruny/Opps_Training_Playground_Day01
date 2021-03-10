using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Day01.Polymorphism
{
	class CompileTimeExample
	{
		public int Add(int a, int b, int c)
		{
			return a + b + c;
		}
		public int Add(int a, int b)
		{
			return a + b;
		}
	}
}
