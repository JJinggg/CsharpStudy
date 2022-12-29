using System;
namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex010
    {
        public void run()
        {

            #region >> string to int 잘못된 예시
            //string strNumber = "10";
            //int intNumber = (int)strNumber;
            #endregion

            //주의사항 : Parse는 문자열 값이 Null인 경우 프로그램에서 에러가 발생함
            //          Convert의 경우엔 0을 반환 해줌

            string strNumber = "10";

            int convertNumber = Convert.ToInt32(strNumber);
            int parseNumber = Int32.Parse(strNumber);

            Console.WriteLine("{0} + {1} = {2}", convertNumber, parseNumber, convertNumber + parseNumber);

        }
    }
}

