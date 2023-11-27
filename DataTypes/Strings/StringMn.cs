using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Strings
{
    public class StringMn
    {
        //value types vs reference types
        //value types are allocated on stack, reference on heap
        //value types memory allocation done automatically, reference memory allocation done on heap
        //value-immediately removed when out of scope, reference-grabage collected by CLR

        //reference types use new keyword(creating memory)
        public void StringManipulation()
        {
            String[] cars = new String[3];
            cars[0] = "Audi";
            cars[1] = "BMW";
            cars[2] = "Mercedes";
        }
        public void StrinPp()
        {
            //strings are immutable
            //quoted string literal - use escape characters whenever using quotes in quotes
            var message = " The coach has said \n \t \'We played well\' ";

            //verbatim string literal - uses @ sign, uses atleast 3 opening quotes
            var message1 = @"""
            write multiple
            lines
            easily
""";
            //Raw string interpolation
            string greetings;
            greetings = "Hola";
            var message8 = $""""
                The coach said the following
                {greetings}
"""";
            //Raw string interpolation -JSON
            string v = $$$"""
                {
                "postId": 1,
                "id": 1,
                "greeting":{{{greetings}}}
                "name": "id labore ex et quam laborum",
                "email": "Eliseo@gardner.biz",
                "body": "laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium"
                }
                """;
        }
        public void immutabilityPractice()
        {
            var str1 = "      ";

            StringBuilder sb = new StringBuilder();
            string text = "   Hello world  ";
            int num1 = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();

            for (int i = 1; i <= 100000; i++)
            {
                //sb.Append(i.ToString());

                num1 += i;
                //Console.WriteLine(i);
            }
            watch.Stop();
            Console.WriteLine("It took" + watch.ElapsedMilliseconds);
        }
        //string methods - 
    }
}
