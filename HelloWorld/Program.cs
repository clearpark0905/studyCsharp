using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string str = (a * b * c).ToString();
        int[] num = new int[10];

        for (int i = 0; i < str.Length; i++)
            num[int.Parse(str[i].ToString())]++;
        for (int i = 0; i < num.Length; i++)
            Console.WriteLine(num[i]);
    }
}
