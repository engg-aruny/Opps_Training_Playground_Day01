using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Training_Day01.Abstraction
{
	// interface declaration 
	interface Vehicle
	{
		// all are the abstract methods. 
		void ChangeGear(int a);

		void SpeedUp(int a);

		void ApplyBrakes(int a);
	}

	// class implements interface 
	class Bicycle : Vehicle
	{

		int speed;
		int gear;

		// to change gear 
		public void ChangeGear(int newGear)
		{

			gear = newGear;
		}

		// to increase speed 
		public void SpeedUp(int increment)
		{

			speed = speed + increment;
		}

		// to decrease speed 
		public void ApplyBrakes(int decrement)
		{

			speed = speed - decrement;
		}

		public void printStates()
		{
			Console.WriteLine("speed: " + speed +
			                  " gear: " + gear);
		}
	}

	// class implements interface 
	class Bike : Vehicle
	{

		int speed;
		int gear;

		// to change gear 
		public void ChangeGear(int newGear)
		{

			gear = newGear;
		}

		// to increase speed 
		public void SpeedUp(int increment)
		{

			speed = speed + increment;
		}

		// to decrease speed 
		public void ApplyBrakes(int decrement)
		{

			speed = speed - decrement;
		}

		public void printStates()
		{
			Console.WriteLine("speed: " + speed +
			                  " gear: " + gear);
		}
	}
}
