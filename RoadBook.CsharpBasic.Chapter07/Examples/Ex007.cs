using System;
namespace RoadBook.CsharpBasic.Chapter07.Examples
{
    public class Ex007
    {
        public void run()
        {
            Console.WriteLine("숫자를 입력하세요");

            int number = -1;
            bool isException = false;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException : 숫자가 아닌값을 입력했습니다");

                isException = true;
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverException : 숫자의 범위를 벗어났습니다");

                isException = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("예외상황 발생, 관리자에게 문의하세요");
                Console.WriteLine("error code : {0}", e.HResult);
                Console.WriteLine("error Message : {0}", e.Message);

                isException = true;
            }
            finally
            {
                if (isException)
                {
                    number = 0;
                }
            }

            Console.WriteLine("입력된 숫자는 {0}", number);
        }
    }
}

