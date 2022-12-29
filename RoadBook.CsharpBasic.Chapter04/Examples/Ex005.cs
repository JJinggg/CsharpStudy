using System;
namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex005
    {
        public void run()
        {
            int final = 1;

            for (int index = 5; index > 0; index--)
            {
                final *= index;
            }

            Console.WriteLine("5!은 {0}입니다.", final);
        }
    }
}

