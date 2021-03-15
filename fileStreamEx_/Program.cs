using System;
using System.IO;

namespace fileStreamEx_
{
    class Program //바이트 단위로 스트림을 읽고 씀 -> 오버헤드 발생 가능성 있는 방법
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"C:\Users\sanghyeok\Documents\Language\CsharpEx\streamTest.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // 생성자는 3가지 방법이 있음
            // 1. fileName, fileMode
            // 2. fileName, fileMode, fileAccess
            // 3. fileName, fileMode, fileAccess, fileShare
            // fileMode의 값 => Append, Create, CreateNew, Open, OpenOrCreate
            // fileAccess의 값 => Read, ReadWrite, Write
            // fileShare의 값 => None, Read, ReadWrite, Write

            for (int i = 65; i <= 90; i++)
            {
                //알파벳 출력,
                fileStream.WriteByte(Convert.ToByte(i));
            }

            fileStream.Close();

            fileStream = new FileStream(@"C:\Users\sanghyeok\Documents\Language\CsharpEx\streamTest.txt", FileMode.Open, FileAccess.Read);

            for (int i = 0; i <= 25; i++)
            {
                //Byte를 다시 Char 형태로 읽어 콘솔화면에 출력
                Console.Write(Convert.ToChar(fileStream.ReadByte()));

            }
            Console.WriteLine();
        }
    }
}
