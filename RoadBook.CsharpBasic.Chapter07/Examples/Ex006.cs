using System;
namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex006
    {
        public void run()
        {
            Console.WriteLine("숫자를 입력하세요");

            int number = 0;

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception : 숫자가 아닌 값을 입력했습니다");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException : 숫자의 범위를 초과했습니다");
            }
            catch (Exception e)
            {
                Console.WriteLine("예측하지 못한 상황 발생, 관리자에게 문의하세요");
                Console.WriteLine("error code : {0}", e.HResult);
                Console.WriteLine("error Message : {0}", e.Message);
            }

            Console.WriteLine("입력된 숫자는 {0}", number);
        }
    }
}

