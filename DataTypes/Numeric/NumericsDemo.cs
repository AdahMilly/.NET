using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Numeric
{
    public class NumericsDemo
    {
        public void learningNumbers()
        {
            //whole numbers - 4 datatypes - byte, short, int, long

            //byte
            //stores numbers btn 0-255
            byte age = 11;

            //short - 16bits
            //ushort - supports only positive
            Console.WriteLine($"the minimum number a short can have is {short.MinValue}");
            Console.WriteLine($"the maximum number a short can have is {short.MaxValue}");

            //int 32bits-4bytes
            Console.WriteLine($"the minimum number an int can have is {int.MinValue}");
            Console.WriteLine($"the maximum number an int can have is {int.MaxValue}");

            //long keyword is long
            //64bits equivalent to 8bytes

            Console.WriteLine($"the minimum number an long can have is {long.MinValue}");
            Console.WriteLine($"the maximum number an long can have is {long.MaxValue}");
        }
        public void learningRealNumbers() {
            //numbers with decimals - float, double, decimal
            //float
            Console.WriteLine($"the minimum number a float can have is {float.MinValue}");
            Console.WriteLine($"the maximum number a float can have is {float.MaxValue}");

            //double
            Console.WriteLine($"the minimum number a double can have is {double.MinValue}");
            Console.WriteLine($"the maximum number a double can have is {double.MaxValue}");

            //decimal
            Console.WriteLine($"the minimum number a decimal can have is {decimal.MinValue}");
            Console.WriteLine($"the maximum number a decimal can have is {decimal.MaxValue}");
        }
        public void learnChar() {
            //holds one letter words
            char grade = 'A';
        }
        public void learningBooleans()
        {
            //evaluates to either true or false
            bool isHappy = true;
        }
    }
}
