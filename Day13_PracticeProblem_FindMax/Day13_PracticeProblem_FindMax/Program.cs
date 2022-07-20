

namespace Day13_FindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum value finder");
            MaxNumberCheck maxNumberCheck = new MaxNumberCheck();
            string string1 = maxNumberCheck.MaximumStringNumber("205", "101", "269");
            Console.WriteLine("Maximum Of string values: {0}", string1);

        }
    }
}