using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class Array
    {
        public static void ToPrint(int[] inputArray)
        {
            foreach (int Element in inputArray)
            {
                Console.WriteLine(Element);
            }
            Console.WriteLine("------------------------------------------");
        }
        public static void ToPrint(double[] inputArray)
        {
            foreach (double Element in inputArray)
            {
                Console.WriteLine(Element);
            }
            Console.WriteLine("------------------------------------------");
        }
        public static void ToPrint(char[] inputArray)
        {
            foreach (char Element in inputArray)
            {
                Console.WriteLine(Element);
            }
            Console.WriteLine("------------------------------------------");
        }
    }
}
