using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Opps_Training_Day01.Abstraction;
using Opps_Training_Day01.ClassObjects;
using Opps_Training_Day01.Polymorphism;

namespace Opps_Training_Day01
{
	class Program
	{
		static void Main(string[] args)
		{

			//*********************************************************************************//
			//Uncomment this for Object/ Class
			//ClassObjectsExample e1 = new ClassObjectsExample();
			//e1.EmployeeNumber = 1;
			//e1.FirstName = "Arun";
			//e1.LastName = "Y";
			//e1.DisplayName();

			//*********************************************************************************//
			//Uncomment this for Abstraction

			//Abstract
			//CallAbstractClassToOutput();

			//Interface
			//CallInterfaceClassToExample1Output();
			//CallInterfaceClassToExample2Output();
			//CallInterfaceClassToExample3Output();


			//*********************************************************************************//
			//Uncomment this for Encapsulation


			//*********************************************************************************//
			//Uncomment this for Inheritance

			//*********************************************************************************//
			//Uncomment this for Polymorphism

			//CompileTime
			//CallCompileTimePolymorphismToOutput();

			//RunTime
			//CallRunTimeExample1PolymorphismToOutput();
			//CallRunTimeExample2PolymorphismToOutput();

			Console.ReadKey();
		}

		private static void CallAbstractClassToOutput()
		{
			/*for example employees working in a firm.
			The firm hires only two types of employees- either driver or developer. 
			Now, you have to develop a software to store the informations about them.*/

			int a, b;

			// 'd1' is object of class and  instantiate class 'Developer' 
			Developer d1 = new Developer(50000);

			// 'd2' is object of class and  instantiate class 'Developer' 
			Driver d2 = new Driver(10000);

			//OR

			//Employee d1 = new Developer(50000);
			//Employee d2 = new Driver(10000);

			a = d1.GetSalary();
			b = d2.GetSalary();

			Console.Write("Salary of developer: " + a);
			Console.Write("Salary of driver: " + b);
			Console.ReadKey();
		}

		private static void CallInterfaceClassToExample1Output()
		{
			ISavingAccount savingAccount = new Account();
			ICurrentAccount currentAccount = new Account();

			savingAccount.PrintAccountData();
			currentAccount.PrintAccountData();

			Console.ReadLine();

			// Creating object 
			TestClass t = new TestClass();

			// calling method 
			t.display();
		}

		private static void CallInterfaceClassToExample2Output()
		{
			ISavingAccount savingAccount = new Account();
			ICurrentAccount currentAccount = new Account();

			savingAccount.PrintAccountData();
			currentAccount.PrintAccountData();

			Console.ReadLine();

			// Creating object 
			TestClass t = new TestClass();

			// calling method 
			t.display();
		}

		private static void CallInterfaceClassToExample3Output()
		{
			// creating an instance of Bicycle  
			// doing some operations  
			Bicycle bicycle = new Bicycle();
			bicycle.ChangeGear(2);
			bicycle.SpeedUp(3);
			bicycle.ApplyBrakes(1);

			Console.WriteLine("Bicycle present state :");
			bicycle.printStates();

			// creating instance of bike. 
			Bike bike = new Bike();
			bike.ChangeGear(1);
			bike.SpeedUp(4);
			bike.ApplyBrakes(3);

			Console.WriteLine("Bike present state :");
			bike.printStates();
		}

		private static void CallCompileTimePolymorphismToOutput()
		{
			CompileTimeExample dataClass = new CompileTimeExample();
			int add2 = dataClass.Add(45, 34, 67);
			int add1 = dataClass.Add(23, 34);
		}

		private static void CallRunTimeExample1PolymorphismToOutput()
		{
			Animal myAnimal = new Animal();  // Create a Animal object
			Animal myPig = new Pig();  // Create a Pig object
			Animal myDog = new Dog();  // Create a Dog object

			myAnimal.animalSound();
			myPig.animalSound();
			myDog.animalSound();
		}
	}
}
