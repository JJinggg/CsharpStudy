using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.works
{
    public class work003
    {
        public void run()
        {
            Console.WriteLine("몇명에게 무료 혜택을 제공할까요?");
            int freeCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("무료 영화 선착순 예매 시스템 입니다");

            Queue<string> que = new Queue<string>();

            while (true)
            {
                Console.Write("이름을 입력해주세요 (q:종료):");
                string Pname = Console.ReadLine();
                
                if (Pname.ToLower() == "q")
                {
                    break;
                }

                que.Enqueue(string.Format(Pname));
            }
            Console.WriteLine("무료영화 당첨자는");
            for (int i = 0; i < freeCount; i++)
            {
                Console.WriteLine(que.Dequeue());
            }

            Console.WriteLine("입니다");
        }
    }
}

