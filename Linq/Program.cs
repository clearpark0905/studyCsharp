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

        // ---------------------------------------------------------------------------
        Console.WriteLine("LINQ 개요");
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


        // ---------------------------------------------------------------------------
        Console.WriteLine("Count(), Max(), Average(), First()");
        // foreach 없이 사용하는 메서드 : Count, Max, Average, First
        int scoreCount = scoreQuery.Count();
        Console.WriteLine(scoreCount);
        // Output : 3


        // ---------------------------------------------------------------------------
        Console.WriteLine("ToList(), ToArray()");
        // foreach 없이 ToList(), ToArray() 사용하여 강제 적용
        int[] numbers1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var numQueryToList = // List<int>로도 선언 가능
            (from num in numbers1
             where (num % 2) == 0
             select num).ToList();

        var numQueryToArray =
            (from num in numbers1
             where (num % 2) == 0
             select num).ToArray();

        foreach (int i in numQueryToList)
        {
            Console.WriteLine(i);
        }
        // Output : 0 2 4 6 8
        // 원하는 경우 List<int>가 아닌 var 키워드를 사용하여 제네릭 구문을 방지할 수 있다.
        // orderby num ascending (or descending)을 사용하여 정렬 가능하다.
        // group ~ by ~ into ~ 구문 사용 가능
        // join ~ in ~ on ~ equals ~ 구문 사용 가능


        // ---------------------------------------------------------------------------
        Console.WriteLine("쿼리 구문과 메서드 구문");
        int[] numbers2 = { 5, 10, 8, 3, 6, 12 };

        // Query syntax :
        IEnumerable<int> numQuery1 =
            from num in numbers2
            where num % 2 == 0
            orderby num
            select num;

        // Method syntax : 
        IEnumerable<int> numQuery2 = numbers2.Where(num => num % 2 == 0).OrderBy(num => num);

        // execution
        Console.WriteLine("Query syntax");
        foreach(int i in numQuery1)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Method syntax");
        foreach (int i in numQuery2)
        {
            Console.WriteLine(i);
        }
        // Output1 : 6 8 10 12        Output2 : 6 8 10 12
        // C#에서 => 는 "goes to"로 읽는 람다 연산자


        // ---------------------------------------------------------------------------
        Console.WriteLine("표준 쿼리 연산자를 사용하여 시퀀스에 대한 정보 가져오기");
        string sentence = "better late than never";
        string[] words = sentence.Split(' ');

        // Query syntax : 
        var query = from word in words
                    group word.ToUpper() by word.Length into gr
                    orderby gr.Key
                    select new { Length = gr.Key, Words = gr };

        // Method syntax : 
        var query2 = words
            .GroupBy(w => w.Length, w => w.ToUpper())
            .Select(g => new { Length = g.Key, Words = g })
            .OrderBy(o => o.Length);

        // execution
        foreach(var obj in query2)
        {
            Console.WriteLine("Words of length {0}:", obj.Length);
            foreach(string word in obj.Words)
            {
                Console.WriteLine(word);
            }
        }

    }
}

