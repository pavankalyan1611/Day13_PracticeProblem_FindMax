

namespace Day13_FindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum value finder Using Generic Method :");

            int[] integer = { 5, 2, 8, 6, 3 };
            double[] doubles = { 54.5664, 4646.4646, 64.464, 87.964, 78.579 };
            string[] strings = {"467","44645","97","969"};
            MaxNumberCheck<int> max = new MaxNumberCheck<int>(integer);
            MaxNumberCheck<double> doub= new MaxNumberCheck<double>(doubles);
            MaxNumberCheck<string> str = new MaxNumberCheck<string>(strings);

            max.testMaximum();
            doub.testMaximum();
            str.testMaximum();
        }
    }
}