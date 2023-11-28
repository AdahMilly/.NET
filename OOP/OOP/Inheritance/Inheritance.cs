using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Inheritance
    {
        //one or more child classes receiving fields, methods, etc. from a common parent
        // single inheritance
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is eating.");
            }
        }

        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Dog is barking.");
            }
        }

        // multi-level inheritance
        class Mammal : Animal
        {
            public void Run()
            {
                Console.WriteLine("Mammal is running.");
            }
        }

        class Horse : Mammal
        {
            public void Gallop()
            {
                Console.WriteLine("Horse is galloping.");
            }
        }

        // hierarchical inheritance
        class Bird : Animal
        {
            public void Fly()
            {
                Console.WriteLine("Bird is flying.");
            }
        }

        class Eagle : Bird
        {
            public void Hunt()
            {
                Console.WriteLine("Eagle is hunting.");
            }
        }

        class Penguin : Bird
        {
            public void Swim()
            {
                Console.WriteLine("Penguin is swimming.");
            }
        }

        // multiple inheritance
        interface I1
        {
            void Method1();
        }

        interface I2
        {
            void Method2();
        }

        class MyClass : I1, I2
        {
            public void Method1()
            {
                Console.WriteLine("Method1 is called.");
            }

            public void Method2()
            {
                Console.WriteLine("Method2 is called.");
            }
        }

        // main program
        class Program
        {
            static void Main(string[] args)
            {
                // single inheritance
                Dog dog = new Dog();
                dog.Eat();
                dog.Bark();

                // multi-level inheritance
                Horse horse = new Horse();
                horse.Eat();
                horse.Run();
                horse.Gallop();

                // hierarchical inheritance
                Eagle eagle = new Eagle();
                Penguin penguin = new Penguin();
                eagle.Fly();
                eagle.Hunt();
                penguin.Fly();
                penguin.Swim();

                // multiple inheritance
                MyClass myClass = new MyClass();
                myClass.Method1();
                myClass.Method2();

                Console.ReadLine();
            }
        }
    }
}

/*namespace secondExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();

            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}*/
