using System;
namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class work01
    {
        public void run()
        {
            Console.WriteLine("숫자를 입력하세요 팩토리얼을 표현해드립니다.");
            int num = Convert.ToInt32(Console.ReadLine());
            int final = 1;

            for (int index = (num); index > 0; index--)
            {
                final *= index;
            }

            Console.WriteLine("{0}!은 {1}입니다.", num, final);

        }
    }
}

