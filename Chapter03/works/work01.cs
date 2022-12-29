using System;
namespace RoadBook.CsharpBasic.Chapter03.works
{
    public class work01
    {
        public void run()
        {
            Random rand = new Random();
            int Num01 = rand.Next(1, 100);
            int Num02 = rand.Next(1, 100);
            Console.WriteLine("다음을 계산하시오. {0}+{1} = ? ", Num01, Num02);
            int result = Convert.ToInt32(Console.ReadLine());
            
            bool cal = ((Num01 + Num02 == result) ? true : false);

            if (cal == true)
            {
                Console.WriteLine("congratulation! your so great!!");
            }
            else
            {
                Console.WriteLine("try agin...");
            }
        }
    }
}

