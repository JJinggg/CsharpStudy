using System;
namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex001
    {
        public void run()
        {
            Console.WriteLine("숫자를 입력하세요 : ");

            int number = Convert.ToInt32(Console.ReadLine());
            //input value : "one"

            Console.WriteLine("입력 된 숫자는 {0}", number);
        }
    }
}

