﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var camry = new Car();

            var f250 = new Truck();

            var equinox = new SUV();

            var vehicles = new List<IVehicle>() { camry, f250, equinox };

            foreach(var vehicle in vehicles)
            {
                var v = vehicle as ICompany;
                v.Company();
                vehicle.Drive();
                vehicle.Vehicle();
                Console.WriteLine("~~~~~~~~~~~"); 
                
            }



            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE Create 2 Interfaces called IVehicle & ICompany

            //DONE Create 3 classes called Car , Truck , & SUV

            //DONE In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //DONE In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //DONE In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
