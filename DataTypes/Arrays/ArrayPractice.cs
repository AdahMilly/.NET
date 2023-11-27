using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Arrays
{
    public class ArrayPractice
    {
        //array-a fixed collection that stores elements of the same type
        public void ArrayPp(int[] array) {
            int[] array1 = {1,2,3,4,5,6,7}; //declare and initialize
            var array2 = array1 as int[];

            array2[0] = 100;

            //accessing arrays
            //1-indexing
            Console.WriteLine(array1[0]);
            //2-iterations - foreach,for loop
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

            //Forloop-- has index/values

            for (int i = 0; i < array1.Count; i++)
            {
                Console.WriteLine($"{i}= {array2[i]}");
            }
            // Insert 
            array1.Insert(2, 1000);
            array1.InsertRange(1, arrayList);
        }
    }
}
