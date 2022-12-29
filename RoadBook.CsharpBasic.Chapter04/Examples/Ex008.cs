using System;
namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex008
    {
        public void run()
        {
            Random rand = new Random();
            int target_number = rand.Next(1, 10);

            Console.WriteLine("1~10 사이의 숫자를 맞춰보세요");

            int count = 0;
            while (Convert.ToInt32(Console.ReadLine()) != target_number)
            {
                Console.WriteLine("틀렸어!");
                count++;
            }

            Console.WriteLine("정답! 맞추기까지 {0}번 소요되었습니다.", count);
        }
    }
}

