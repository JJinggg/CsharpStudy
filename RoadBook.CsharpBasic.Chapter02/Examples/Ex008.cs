using System;
namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex008
    {
        public void run()
        {
            int korea = 100;
            int english = 100;
            int math = 98;
            int sports = 97;

            #region >> 형 변환 예시 in CWK
            int totalScore = (korea + english + math + sports);
            double avgScore = ((double)totalScore / 4);
            #endregion

            #region >> 형 변환 예시 in Books
            //double totalScore = (korea + english + math + sports);
            #endregion

            #region >> 잘못된 형 변환 예시
            //int totalScore = (korea + english + math + sports);
            //int data는 더 큰 범위의 double data로 변환이 가능하나 반대의 경우에는 안된다
            //예를들어 밑의 형 변환 처럼 double을 int로 낮추는 경우에는 에러가 발생하게 된다 
            //int avgScore = ((double)totalScore / 4);
            #endregion


            Console.WriteLine("총점 = {0}, 평균 = {1}", totalScore, avgScore);
            Console.WriteLine("평균 = {0}", avgScore);
            Console.WriteLine("평균 = {0}", (double)totalScore / 4);
        }
    }
}

