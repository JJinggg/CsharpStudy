using System;
namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex002
    {
        public void run()
        {
            List<string> strList = new List<string>();

            strList.Add("Hi");
            Console.WriteLine(strList[0]);

            strList.Clear();
            Console.WriteLine(strList[0]);
        }
    }
}

