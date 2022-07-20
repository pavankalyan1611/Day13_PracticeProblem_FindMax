

namespace Day13_FindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum value finder Using Generic Method :");

            int[] intArray = { 3, 5, 1, 2, 4};
            double[] doubleArray = { 1.167, 98347.4,444.96, 4.4 };
            string[] stringArray = {"pAvan","Mani","pAVan","maNi"};

            MaxNumberCheck.FindMax<int>(intArray);
            MaxNumberCheck.FindMax<double>(doubleArray);
            MaxNumberCheck.FindMax<string>(stringArray);
        }
    }
}