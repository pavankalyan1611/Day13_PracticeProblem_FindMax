

namespace Day13_FindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum value finder Using Generic Class :");

            int[] intArray = { 112, 432, 344, 555, 67 };
            GenericMaximum<int> genericInt = new GenericMaximum<int>(intArray);
            genericInt.PrintMaxValue();

            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333", "55", "9" };

            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();

        }
    }
}