using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // LINQ(Language-Integrated Query) : C#언어에 직접 쿼리 기능을 통합하는 방식을 기반으로 하는 기술 집합 이름
        // 최소한의 코드로 데이터 소스에 대해 필터링, 정렬, 그룹화 작업을 수행할 수 있다.
        // SQL Server, XML, ADO.NET 및 IEnumerable, IEnumeralbe<T> 등 모든 개체 컬렉션에 대해 쿼리 작성 가능함.
        // LINQ query는 3가지 파트로 나뉘어져 있다.

        Console.WriteLine("LINQ introduction");
        // 1. Data source
        int[] scores = new int[] { 97, 92, 81, 60 };

        // 2. Query creation
        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;

        // 3. Query execution
        foreach (int i in scoreQuery)
        {
            Console.Write(i + " ");
        }
        // Output : 97, 92, 81



        Console.WriteLine("Count(), Max(), Average(), First()");
        // foreach 없이 사용하는 메서드 : Count, Max, Average, First
        int scoreCount = scoreQuery.Count();
        Console.WriteLine(scoreCount);
        // Output : 3



        Console.WriteLine("ToList(), ToArray()");
        // foreach 없이 ToList(), ToArray() 사용하여 강제 적용
        int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        List<int> numQueryToList =
            (from num in numbers
             where (num % 2) == 0
             select num).ToList();

        var numQueryToArray =
            (from num in numbers
             where (num % 2) == 0
             select num).ToArray();

        foreach (int i in numQueryToArray)
        {
            Console.WriteLine(i);
        }



    }
}

