using System;
namespace RoadBook.CsharpBasic.Chapter07.works
{
    public class work001
    {
        public void run()
        {
            Console.WriteLine("숫자를 입력하세요");

            int number = 0;
            bool isException = false;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("형식이 잘못 되었습니다");

                isException = true;
            }
            catch (OverflowException)
            {
                Console.WriteLine("숫자의 범위를 벗어났습니다");

                isException = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("예외상황 발생, 관리자에게 문의 하세요");
                Console.WriteLine("error code {0}", e.HResult);
                Console.WriteLine("error Message {0}", e.Message);
            }
            if (isException == true)
            {
                number = -1;
            }
            Console.WriteLine(number);
        }
    }
}

