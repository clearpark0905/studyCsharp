using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        int sum = 0;
        foreach (char a in str)
            sum = sum + Convert.ToInt32(a) - 48;
        Console.WriteLine(sum);
    }
}
