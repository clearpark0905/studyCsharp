using System;
using System.IO;

namespace fileInfo_
{
    class Program //파일, 디렉터리의 정보 출력
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\sanghyeok\Documents\Language\CsharpEx\test.txt");
            fileInfo.Create();

            if (fileInfo.Exists)
            {
                Console.WriteLine("폴더 이름 : {0}", fileInfo.DirectoryName);
                Console.WriteLine("파일 이름 : {0}", fileInfo.Name);
                Console.WriteLine("파일 확장자 : {0}", fileInfo.Extension);
                Console.WriteLine("파일 크기 : {0}", fileInfo.Length);
                Console.WriteLine("파일 속성 : {0}", fileInfo.Attributes);
                Console.WriteLine("\n");



            }
            else
            {
                Console.WriteLine("그런 파일은 존재 하지 않습니다.");
                Console.WriteLine("\n");


            }

            if (File.Exists(@"C:\Users\sanghyeok\Documents\Language\CsharpEx\test.txt"))
            {
                Console.WriteLine("폴더 이름 : {0}", File.GetCreationTime(@"C:\Users\sanghyeok\Desktop\test.txt"));
                Console.WriteLine("최종 접근한 시간 : {0}", File.GetLastAccessTime(@"C:\Users\sanghyeok\Desktop\test.txt"));
                Console.WriteLine("마지막으로 쓰여진 시간 : {0}", File.GetLastWriteTime(@"C:\Users\sanghyeok\Desktop\test.txt"));
                Console.WriteLine("\n");

            }
            else
            {
                Console.WriteLine(" 그런 파일은 존재 하지 않습니다.");
                Console.WriteLine("\n");


            }

            //여기까지 파일에 관한 내용 출력
            //이후로는 디렉터리에 관한 내용 출력

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\sanghyeok\Documents\Language\CsharpEx");

            if (directoryInfo.Exists)
            {
                DirectoryInfo[] dir = directoryInfo.GetDirectories(); //하위 디렉토리 파일정보 출력

                foreach (DirectoryInfo d in dir)
                {
                    FileInfo[] files = d.GetFiles();
                    Console.WriteLine("디렉토리 : {0}, 포함된 파일 수 : {1}", d.FullName, files.Length);

                    int index = 0;
                    foreach (FileInfo f in files)
                    {
                        Console.WriteLine("{0} : 파일명:{1}, 확장자:{2}, 크기:{3}", ++index, f.Name, f.Extension, f.Length);

                    }
                }
            }

        }
    }
}
