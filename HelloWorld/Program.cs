using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ab = Console.ReadLine().Split(" ");
            Console.WriteLine(Convert.ToInt32(ab[0]) + Convert.ToInt32(ab[1]));
        }
    }
}
