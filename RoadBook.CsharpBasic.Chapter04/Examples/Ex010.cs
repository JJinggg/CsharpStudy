using System;
namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex010
    {
        public void run()
        {
            Random rand = new Random();
            int target_number = rand.Next(1, 10);

            Console.WriteLine("1~10까지의 숫자를 맞춰보아요");

            int count = 0;
            bool isMatched = false;
            do
            {
                if (Convert.ToInt32(Console.ReadLine()) == target_number)
                {
                    isMatched = true;
                    Console.WriteLine("정답! 맞추기까지 {0}번 소요되었습니다", count);

                }
                else
                {
                    Console.WriteLine("땡!");
                    count++;
                }
            } while (isMatched == false);
        }
    }
}


