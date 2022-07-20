

namespace Day13_FindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum value finder");
            MaxNumberCheck maxNumberCheck = new MaxNumberCheck(); //Create Object
            double Double = maxNumberCheck.MaxFloatNumber(1.2466, 6.6445664664, 5.6456);
            Console.WriteLine("Maximum Of floting values: {0}", Double);


        }
    }
}
