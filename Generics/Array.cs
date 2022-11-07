using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class Array
    {
        public static void ToPrint<M>(M[] inputArray)
        {
            foreach (M Element in inputArray)
            {
                Console.WriteLine(Element);
            }
            Console.WriteLine("------------------------------------------");
        }
    }
}
