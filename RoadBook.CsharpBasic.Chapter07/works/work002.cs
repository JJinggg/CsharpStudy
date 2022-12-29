using System;
using RoadBook.CsharpBasic.Chapter07.Examples.UserException;

namespace RoadBook.CsharpBasic.Chapter07.works
{
    public class work002
    {
        public void run()
        {
            Random rand = new Random();
            int target_num = rand.Next(0, 10);
            bool isMatched = false;
            int Count = 0;
            do
            {
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > 10 || num < 0)
                    {
                        throw new MyStyleException("범위를 벗어났습니다");
                    }
                     if (num != target_num)
                    {
                        Console.WriteLine("틀렸습니다");
                        if (num < target_num)
                        {
                            Console.WriteLine("up!");
                        }
                        else if (num > target_num)
                        {
                            Console.WriteLine("down!");
                        }
                        
                    }
                    else
                    {
                        isMatched = true;
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

                Count++;

             

                
            }
            while (isMatched == false);
            { Console.WriteLine("정답까지 {0}회 걸렸습니다", Count); }
        }
    }
}

