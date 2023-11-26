using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.TypeConversion
{
    public class TypeConversionDemo
    {
        public void ImplicitConversion()
        {
            byte num1 = 15;
            int num2 = num1;
            long num3 = num2;
            float num4 = num3;
            double num5 = num4;
        }
        public void ExplicitConversion()
        {
            //has a risk of data loss during conversion, converting a bigger data type to a smaller data type
            int num1 = 350;
            byte num2 = (byte)num1;
        }
        public void NonCompartibleConversions()
        {
            //we use helper methods to convert non-compartible. Convert, Parse, TryParse
            string num1 = "100";
            int num2 = Convert.ToInt32(num1);

            //Parse - will throw an error if not possible
            int num3 = int.Parse(num1);

            //TryParse - exception thrown but not handled
            string num5 = "Hello";
            bool b2 = true;
            bool b4 = int.TryParse(num5, out int num6);

        }
    }
}
