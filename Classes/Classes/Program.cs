// See https://aka.ms/new-console-template for more information
using Classes;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // class = A bundle of related code.
            // Can be used as a blueprint to create objects (OOP)

            ClassIntroduction.Hello();
            ClassIntroduction.Waiting();
            ClassIntroduction.Bye();

            Console.ReadKey();
        }
    }
}