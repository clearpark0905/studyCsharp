using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] sungjuk = Console.ReadLine().Split(' ');
        float[] sungjukFloat = Array.ConvertAll(sungjuk, float.Parse);

        float maxScore = float.MinValue;
        foreach(float f in sungjukFloat)
        {
            if(maxScore < f)
            {
                maxScore = f;
            }
        }

        float sum = 0;
        for(int i=0; i<sungjukFloat.Length; i++)
        {
            sum += (sungjukFloat[i] /maxScore) * 100;
        }

        Console.WriteLine(sum / n);
        
    }
}
