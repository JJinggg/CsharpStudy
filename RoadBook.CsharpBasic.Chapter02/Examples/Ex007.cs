using System;
namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex007
    {
        public void run()
        {
            int korea = 100;
            int english = 100;
            int math = 98;
            int sports = 97;

            int totalScore = (korea + english + math + sports);
            int avgScore = totalScore / 4;

            #region >> made in CWK
            //Console.WriteLine("총점 = {0}, 평균 = {1}", totalScore, avgScore);
            #endregion

            #region >> Made in books
            Console.WriteLine("평균 = {0}", totalScore);
            Console.WriteLine("평균 = {0}", totalScore / 4);
            #endregion
        }
    }
}

