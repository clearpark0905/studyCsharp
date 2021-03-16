using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_4344_AboveAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int students = int.Parse(line[0]);
                int[] studentScore = new int[students];
                int sum = 0;
                for(int j=0; j<students; j++)
                {
                    studentScore[j] = int.Parse(line[j+1]);
                    sum += studentScore[j];
                }
                int aboveAvgStudent = 0;
                for (int j = 0; j < students; j++)
                {
                    if(studentScore[j] > sum/students)
                    {
                        aboveAvgStudent++;
                    }
                }
                double a = Math.Round((double)100 * aboveAvgStudent / students, 3);
                sb.AppendLine(String.Format("{0:0.000}%", a));
            }
            Console.WriteLine(sb);
        }
    }
}
