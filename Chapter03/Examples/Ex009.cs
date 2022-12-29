using System;
namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex009
    {
        public void run()
        {
            Console.WriteLine("영화제목을입력하게");
            string Movie = Console.ReadLine();
            Console.WriteLine("{0}의 평점을 입력(0~5점 사이)", Movie);
            int rating = Convert.ToInt32(Console.ReadLine());

            if (rating == 0)
            {
                Console.WriteLine("{0}은 정말 최악이군요", Movie);
            }
            else if (rating == 1)
            {
                Console.WriteLine("{0}은 지루하군요", Movie);
            }
            else if (rating == 2)
            {
                Console.WriteLine("{0}은 평범하군요", Movie);
            }
            else if (rating == 3)
            {
                Console.WriteLine("{0}은 완성도가 높군요", Movie);
            }
            else if (rating == 4)
            {
                Console.WriteLine("{0}은 흥미를 유발할 만한 영화군요", Movie);
            }
            else if (rating == 5)
            {
                Console.WriteLine("{0}은 당신에게 있어서 정말 최고의 영화군요", Movie);
            }
            else
            {
                Console.WriteLine("평점계산에 실패했습니다.");
            }

        }
    }
}

