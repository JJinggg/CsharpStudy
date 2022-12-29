using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex002
    {
        private readonly string currenDirectory = Environment.CurrentDirectory;

        public void run()
        {
            using (StreamWriter sw = new StreamWriter(currenDirectory + @"\data\log.txt", true))
            {
                sw.WriteLine("프로그램 실행 시간 : {0}", DateTime.Now);
            }

            
        }
    }
}

