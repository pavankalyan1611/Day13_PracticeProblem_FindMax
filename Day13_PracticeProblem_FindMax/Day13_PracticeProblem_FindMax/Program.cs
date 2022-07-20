

namespace Day13_FindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum value finder Using Generic Method :");          

            MaxNumberCheck.FindMax<int>(1,5,3,6,7,674646,7844,898938);
            MaxNumberCheck.FindMax<double>(3453.6464,546.543,45.67,35.436,65.578,46.546,8);
            MaxNumberCheck.FindMax<string>("pav","PAVAN","Kalyan","KAlyan", "BridgeLabzs");
        }
    }
}