using System;
namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class work03
    {
        int won = 0;
        
        
public void run()
        {
            
            bool final = false;
            do
            {
                

                Console.WriteLine("****안녕하세요 Road Bank입니다.****\r\n" +
                                "1: 잔액조회\r\n" +
                                "2: 입금\r\n" +
                                "3: 출금\r\n" +
                                "0: 종료\r\n" +
                                "*******************************");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        final = true;
                        break;
                    case 1:
                        Console.WriteLine("잔액은 '{0}'원 입니다.", won);
                        break;
                    case 2:
                        Console.WriteLine("입금할 금액을 입력하세요");
                        int uwon = Convert.ToInt32(Console.ReadLine());
                        won += uwon;
                        Console.WriteLine("입금되었습니다.");
                        break;
                    case 3:
                        Console.WriteLine("출금할 금액을 입력하세요.");
                        int dwon = Convert.ToInt32(Console.ReadLine());
                        won -= dwon;
                        if (won <= 0)
                        {
                            Console.WriteLine("잔액이 부족합니다");
                            won += dwon;
                        }
                        else
                        {
                            Console.WriteLine("출금되었습니다.");
                        }
                        break;

                    default:
                        Console.WriteLine("잘못 입력하셨습니다");
                        break;
                }

            } while (final == false);

            Console.WriteLine("감사합니다");
        }
    }
}

