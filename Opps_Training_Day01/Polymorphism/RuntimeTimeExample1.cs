using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Opps_Training_Day01.Polymorphism
//{
//	class Animal  // Base class (parent) 
//	{
//		public void animalSound()
//		{
//			Console.WriteLine("The animal makes a sound");
//		}
//	}

//	class Pig : Animal  // Derived class (child) 
//	{
//		public void animalSound()
//		{
//			Console.WriteLine("The pig says: wee wee");
//		}
//	}

//	class Dog : Animal  // Derived class (child) 
//	{
//		public void animalSound()
//		{
//			Console.WriteLine("The dog says: bow wow");
//		}
//	}
//}



/****************************************************************************************************/

namespace Opps_Training_Day01.Polymorphism
{
	class Animal  // Base class (parent) 
	{
		public virtual void animalSound()
		{
			Console.WriteLine("The animal makes a sound");
		}
	}

	class Pig : Animal  // Derived class (child) 
	{
		public override void animalSound()
		{
			Console.WriteLine("The pig says: wee wee");
		}
	}

	class Dog : Animal  // Derived class (child) 
	{
		public override void animalSound()
		{
			Console.WriteLine("The dog says: bow wow");
		}
	}
}





