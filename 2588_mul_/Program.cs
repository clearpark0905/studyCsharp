using System;

class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[6];
        num[0] = int.Parse(Console.ReadLine());
        num[1] = int.Parse(Console.ReadLine());
        int i = 4;
        foreach (char c in num[1].ToString())
        {
            num[i] = ((int)c - 48) * num[0];
            i--;
        }
        num[5] = num[0] * num[1];
        for (int j = 2; j < 6; j++)
            Console.WriteLine(num[j]);
    }
}
