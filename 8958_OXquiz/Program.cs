using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8958_OXquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] TestCase = new string[n];
            for(int i=0; i<n; i++)
            {
                string temp;
                int cnt = 0;
                int score = 0;
                TestCase[i] = Console.ReadLine();
                for(int j=0; j<TestCase[i].Length;j++)
                {
                    temp = TestCase[i].Substring(j, 1);
                    if(temp.Equals("O"))
                    {
                        score += ++cnt;
                    } 
                    else
                    {
                        cnt = 0;
                    }
                    
                }
                Console.WriteLine(score);
            }

        }
    }
}
