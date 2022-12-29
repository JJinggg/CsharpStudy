using System;
namespace RoadBook.CsharpBasic.Chapter02.work
{
    public class work01
    {
        public void run()
        {
            Console.WriteLine("숫자를 비교해보세요 !");
            string str01 = Console.ReadLine();
            string str02 = Console.ReadLine();

            int Num01 = Convert.ToInt32(str01);
            int Num02 = Convert.ToInt32(str02);

            bool bCalculate01 = (Num01 > Num02);

            Console.WriteLine("첫번째 수가 두번째 보다 큽니까 ? {0}", bCalculate01);


            int number01;
            int number02;

            Console.WriteLine("Insert Number twice:");
            number01 = Convert.ToInt32(Console.ReadLine());
            number02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}is {1}better (T/F: {2})",
                number01,
                number02,
                (number01 > number02));



        }
    }
}

