

namespace Day13_FindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum value finder");
            // MaxNumberCheck maxNumberCheck = new MaxNumberCheck();
            int integers = MaxNumberCheck.MaxIntegerNumber(9, 6, 2);
            Console.WriteLine("Maximum Of Integer values: {0}",integers);
            double Double = MaxNumberCheck.MaxFloatNumber(1.2466, 6.6445664664, 5.6456);
            Console.WriteLine("Maximum Of floting values: {0}", Double);


        }
    }
}