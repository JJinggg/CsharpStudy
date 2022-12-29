using System;
namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex009
    {
        public void run()
        {
            int number01 = 10;
            double number02 = number01;
            int number03 = (int)number02;

            Console.WriteLine("number01의 변수 타입은 {0}", number01.GetType());
            Console.WriteLine("number02의 변수 타입은 {0}", number02.GetType());
            Console.WriteLine("number03의 변수 타입은 {0}", number03.GetType());
        }
    }
}

