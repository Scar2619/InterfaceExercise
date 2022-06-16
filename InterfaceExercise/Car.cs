using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool Trunk { get; set; } = true;
        public bool SportMode { get; set; } = true;

        public int NumberOfWheels { get; set; } = 4;
        public string Model { get; set; } = "Camry";
        public string Make { get; set; } = "Toyota";
        public int Year { get; set; } = 2022;

        public string Name { get ; set ; } = "Toyota";
        public string Logo { get; set; } = "Let's Go Places";

        public void Company()
        {
            Console.WriteLine($"{Name} is popular all around the world.");
        }

        public void Drive()
        {
            Console.WriteLine($"This {GetType().Name} is driving in circles!");

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