using System;
namespace RoadBook.CsharpBasic.Chapter03.works
{
    public class work02
    {
        public void run()
        {
            Console.WriteLine("중간고사 성적을 입력하세요");
            int mid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("기말고사 성적을 입력하세요");
            int final = Convert.ToInt32(Console.ReadLine());

            double avg = (mid + final) / 2.0;

            if (avg >= 90)
            {
                Console.WriteLine("grade : A ({0})", avg);
            }
            else if (avg >= 80 && avg < 90)
            {
                Console.WriteLine("grade : B ({0})", avg);
            }
            else if (avg >= 70 && avg < 80)
            {
                Console.WriteLine("grade : C ({0})", avg);
            }
            else
            {
                Console.WriteLine("grade : F ({0})", avg);
            }
        }
    }
}

