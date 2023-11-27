using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Arrays
{
    public class ArrayPractice
    {
        public void ArrayPp(int[] array) {
            int[] array1 = {1,2,3,4,5,6,7};
            var array2 = array1 as int[];

            array2[0] = 100;
        }
    }
}
