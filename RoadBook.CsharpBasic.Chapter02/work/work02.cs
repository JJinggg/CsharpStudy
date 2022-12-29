using System;
namespace RoadBook.CsharpBasic.Chapter02.work
{
    public class work02
    {
        dynamic? Number01;
        dynamic? Number02;
        dynamic? sNum;
        dynamic? aNum;
        dynamic? mNum;
        private void Sum()
        {
            sNum = Number01 + Number02;
        }
        private void Avg()
        {
            aNum = (double)(Number01 + Number02) / 2;
        }
        private void Mulitple()
        {
            mNum = (Number02 * Number01);
        }
        public void run()
        {
            Console.WriteLine("숫자를 2번 입력하세요");
            Number01 = Convert.ToInt32(Console.ReadLine());
            Number02 = Convert.ToInt32(Console.ReadLine());
            Sum();
            Avg();
            Mulitple();
            Console.WriteLine("결과를 확인해주세요");
            Console.WriteLine("{0}+{1}={2}", Number01,Number02,sNum);
            Console.WriteLine("({0}+{1})/2={2}", Number01, Number02, aNum);
            Console.WriteLine("{0}*{1}={2}", Number01, Number02, mNum);
        }
    }
}

