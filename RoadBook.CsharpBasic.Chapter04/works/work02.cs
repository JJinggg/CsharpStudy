using System;
namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class work02
    {
        public void run()
        {
            Random rand = new Random();
            int num =  rand.Next(1, 50);

            Console.WriteLine("1부터 50까지의 수를 입력하시오");

           
            bool isMatched = false;
            do
            {
                int ans = Convert.ToInt32(Console.ReadLine());
                if ( ans == num)
                {
                    isMatched = true;
                    Console.WriteLine("정답입니다!");
                }
                else if (ans < num)
                {
                    Console.WriteLine("틀렸습니다!. UP!");
                }
                else
                {
                    Console.WriteLine("틀렸습니다! Down!");
                }


            } while (isMatched == false);

            


        }
    }
}

