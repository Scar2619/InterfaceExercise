using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
        public bool Hatchback { get; set; } = false;
        public bool ThirdRow { get; set; } = true;

        public int NumberOfWheels { get; set; } = 4;
        public string Model { get; set; } = "Equinox";
        public string Make { get; set; } = "Chevy";
        public int Year { get; set; } = 2015;

        public string Name { get; set; } = "Chevrolet";
        public string Logo { get; set; } = "Chevy Runs Deep";

        public void Company()
        {
            Console.WriteLine($"{Name} is pretty popular.");
        }

        public void Drive()
        {
            Console.WriteLine($"This {GetType().Name} is a great family car to drive!");
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