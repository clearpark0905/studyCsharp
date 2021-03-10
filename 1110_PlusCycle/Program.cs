using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int temp = 100;
        int prevNum = num;
        int i = 0;
        while(num != temp)
        {
            i++;
            temp = (prevNum%10)*10 + ((prevNum/10) + (prevNum%10))%10;
            prevNum = temp;
        }
        Console.WriteLine(i);
    }
}
