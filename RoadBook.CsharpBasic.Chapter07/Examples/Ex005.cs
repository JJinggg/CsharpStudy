using System;
namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex005
    {
        public void run()
        {
            Console.WriteLine("숫자를 입력하세요 : ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("입력된 숫자는 {0}", number);
            }
            catch(FormatException)
            {
                Console.WriteLine("Format Exception : 숫자가 아닌값을 입력했습니다");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow Exception : 숫자의 범위를 초과했습니다");
            }
            catch(Exception e)
            {
                Console.WriteLine("예측하지 못한 예외발생, 관리자에게 문의하세요");
                Console.WriteLine("error code : {0}", e.HResult);
                Console.WriteLine("error Message : {0}", e.Message);
            }
        }
    }
}

