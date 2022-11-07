namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] intarray = { 1, 2, 3, 4, 5 };
            double[] doublearray = { 1.1, 2.2, 3.3, 4.4 };
            char[] chararray = { 'H', 'E', 'L', 'L', 'O' };

            Array.ToPrint(intarray);
            Array.ToPrint(doublearray);
            Array.ToPrint(chararray);

        }
    }
}