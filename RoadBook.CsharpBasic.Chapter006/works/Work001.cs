using System;

namespace RoadBook.CsharpBasic.Chapter06.works
{
    public class Work001
    {
        public void run()
        {
            ///<summary>
            ///나이 입력
            ///</summary>

            int[] aList = new int[10];
           

            for (int idx = 0; idx < aList.Length; idx++)
            {
                Console.WriteLine("{0}번째 사람의 나이를 입력하세요", idx+1);
                aList[idx] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("나이 입력이 완료되었습니다");

            ///<summary>
            ///통계 내기
            ///</summary
            int _20_down = 0;
            int _20 = 0;
            int _30 = 0;
            int _40 = 0;
            int _50 = 0;
            int _60_up = 0;

            for (int idx = 0; idx < aList.Length; idx++)
            {
                if ( aList[idx] < 20)
                {
                    _20_down++;
                }
                else if (aList[idx] > 20 && aList[idx] < 30)
                {
                    _20++;
                }
                else if (aList[idx] > 30 && aList[idx] < 40)
                {
                    _30++;
                }
                else if (aList[idx] > 40 && aList[idx] < 50)
                {
                    _40++;
                }
                else if (aList[idx] > 50 && aList[idx] < 60)
                {
                    _50++;
                }
                else
                {
                    _60_up++;
                }
            }

            Console.WriteLine("20대 미만: {0}명", _20_down);
            Console.WriteLine("20대: {0}명", _20);
            Console.WriteLine("30대: {0}명", _30);
            Console.WriteLine("40대: {0}명", _40);
            Console.WriteLine("50대: {0}명", _50);
            Console.WriteLine("60대 이상: {0}명", _60_up);

        }
    }
}

