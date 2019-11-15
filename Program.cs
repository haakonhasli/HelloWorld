using System;

namespace hello
{
    class Program
    {
        static int number;
        static string message = "Hei";

        static void Main(string[] args)
        {
            Random eple = new Random();
            number = eple.Next(32, 87);
            string numster = number.ToString();
            string finalmessage = string.Format("{0} {1}", message, numster);
            int test = 0;



            Console.WriteLine($"{message} {numster}");

        }
    }
}
