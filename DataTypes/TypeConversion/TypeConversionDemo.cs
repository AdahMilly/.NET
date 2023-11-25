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
            //has a risk of data loss during conversion
            int num1 = 350;
            byte num2 = (byte)num1;
        }
        public void NonCompartibleConversions()
        {

        }
    }
}
