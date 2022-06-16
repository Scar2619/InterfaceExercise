using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public bool CoveredBed { get; set; } = false;
		public bool FourWheelDrive { get; set; } = true;

        public int NumberOfWheels { get; set; } = 4;
        public string Model { get; set; } = "F250";
        public string Make { get; set; } = "Ford";
        public int Year { get; set; } = 2016;

        public string Name { get; set; } = "Ford";
        public string Logo { get; set; } = "Built Ford Tough";

        public void Company()
        {
            Console.WriteLine($"{Name} is all around the world.");
        }

        public void Drive()
        {
            Console.WriteLine($"This {GetType().Name} is driving off-road!");
        }

        public void Vehicle()
        {
            Console.WriteLine($"This {GetType().Name} is a {Year} {Make} {Model}. {Name}: {Logo}.");
        }
    }
}

//In each of your car, truck, and suv classes

/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 * 
 */