using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.works
{
    public class work004
    {
        public void run()
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            dict.Add("A", new List<string> { "대한민국", "프랑스", "미국", "이집트" });
            dict.Add("H", new List<string> { "일본", "브라질", "독일", "스페인" });

            while (true)
            {
                Console.WriteLine("조 추첨 결과 어느 조를 조회할까요?(q: 종료)");
                string word = Console.ReadLine();

                if (word.ToLower() == "q")
                { break; }

                List<string> group = dict[word];

                Console.WriteLine("{0}조에 속한 나라는",word);
                foreach (object obj in group)
                {
                    Console.WriteLine("{0}", obj.ToString());
                }
                Console.WriteLine("입니다");
            }
            Console.WriteLine("종료되었습니다");
        }
    }
}

