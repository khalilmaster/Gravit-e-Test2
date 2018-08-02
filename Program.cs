using System;
using System.Collections.Generic;
using System.Linq;

namespace gravit_e_test_2
{
    class Program
    {
        static void Main()
        {

            int[] numbersA = { 1, 2, 3, 4, 5 };
            int[] numbersB = { 1, 2, 3, 0, 5 };

            IEnumerable<int> aOnlyNumbers = numbersA.Except(numbersB);
            IEnumerable<int> bOnlyNumbers = numbersB.Except(numbersA);
            Console.WriteLine("Array A:");
            foreach (var a in aOnlyNumbers)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Array B:");
            foreach (var b in bOnlyNumbers)
            {
                Console.WriteLine(b);
            }
        }
    }
}
