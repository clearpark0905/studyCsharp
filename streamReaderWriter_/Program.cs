using System;
using System.IO;

namespace streamReaderWriter_
{
    class Program //streamReader, streamWriter 사용법
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"C:\Users\sanghyeok\Documents\Language\CsharpEx\streamReaderWriterTest.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // StreamReader 메소드
            // Read(), ReadLine(), ReadToEnd(), ReadBlock(), Peek(), ToString, DiscardBufferedData(), Close()
            // StreamWriter 메소드
            // Write(), WriteLine(), Flush(), Close()


            StreamWriter sw = new StreamWriter(fileStream);

            sw.WriteLine("Stream 클래스 예제");
            sw.WriteLine("StreamReader 클래스와 StreamWriter 클래스 배우기");
            sw.WriteLine("StreamReader와 StreamWriter를 사용하면 문장 단위로 쉽게 처리가 가능합니다.");
            sw.Close();

            fileStream.Close();

            fileStream = new FileStream(@"C:\Users\sanghyeok\Documents\Language\CsharpEx\streamReaderWriterTest.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStream);

            while (sr.Peek() > -1) //읽을 스트림이 없을 때까지 읽는다.
            {
                Console.WriteLine(sr.ReadLine());

            }
            sr.Close();
            fileStream.Close();
        }
    }
}
