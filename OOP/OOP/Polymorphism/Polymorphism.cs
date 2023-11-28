using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    internal class Polymorphism
    {
        //Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
        //objects can be identified by more than one form
        //Ex. A dog is also: Canine, Animal, Organism
        class Program
        {
            static void Main(string[] args)
            {

                // polymorphism = Greek word that means to "have many forms"
                //                Objects can be identified by more than one type
                //                Ex. A Dog is also: Canine, Animal, Organism

                Car car = new Car();
                Bicycle bicycle = new Bicycle();
                Boat boat = new Boat();

                Vehicle[] vehicles = { car, bicycle, boat };

                foreach (Vehicle vehicle in vehicles)
                {
                    vehicle.Go();
                }

                Console.ReadKey();
            }
        }
        class Vehicle
        {
            public virtual void Go()
            {

            }
        }
        class Car : Vehicle
        {
            public override void Go()
            {
                Console.WriteLine("The car is moving!");
            }
        }
        class Bicycle : Vehicle
        {
            public override void Go()
            {
                Console.WriteLine("The bicycle is moving!");
            }
        }
        class Boat : Vehicle
        {
            public override void Go()
            {
                Console.WriteLine("The boat is moving!");
            }
        }
    }
}
