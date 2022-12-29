using System;
using RoadBook.CsharpBasic.Chapter05.Examples.model;
namespace RoadBook.CsharpBasic.Chapter05.works
{
    public class work03
    {
        public void run()
        {
            BankAccount Bank = new BankAccount();
            
            Console.WriteLine("****안녕하세요 Road Bank입니다.****\r\n" +
                                "1: 계좌만들기\r\n" +
                                "2: 잔액조회\r\n" +
                                "3: 입금\r\n" +
                                "4: 출금\r\n" +
                                "0: 종료\r\n" +
                                "*******************************");
            while(true)
            { 

            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0) { break; }
            
            switch(num)
                {
                    case 1:
                        Console.Write("통장 고유이름을 입력하세요: ");
                        Bank.BankName = Console.ReadLine();
                        Console.Write("통장 개설자이름을 입력하세요: ");
                        Bank.UserName = Console.ReadLine();
                        Console.Write("'{0}'님의 '{1}'이 개설되었습니다", Bank.UserName, Bank.BankName);

                        break;

                    case 2:
                        Console.WriteLine("잔액은 '{0}'원 입니다", Bank.Money);
                        break;

                    case 3:
                        Console.Write("입금할 금액을 입력하세요");
                        int uMoney = Convert.ToInt32(Console.ReadLine());
                        Bank.Money += uMoney;
                        Console.Write("입금되었습니다요");
                        break;

                    case 4:
                        Console.Write("출금할 금액을 입력하세요");
                        int dMoney = Convert.ToInt32(Console.ReadLine());

                        Bank.Money -= dMoney;
                        if (Bank.Money <= 0)
                        {
                            Console.WriteLine("잔액이 부족합니다");
                            Bank.Money += dMoney;
                        }
                        else
                        {
                            Console.WriteLine("출금되었습니다.");
                        }
                        
                        break;
                    
                    default:
                        Console.Write("잘못입력했습니다");
                        break;

                }

                
            }
            Console.Write("감사합니다");
        }
    }
}

