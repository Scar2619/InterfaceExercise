using System;
namespace InterfaceExercise
{
	public interface ICompany
	{
		public string Name { get; set; }
		public string Logo { get; set; }

		public void Company();
	}
}

//In ICompany

/*Create 2 members that are specific to each every company
 * regardless of vehicle type.
 *
 *
 * Example: public string Logo { get; set; }
 */