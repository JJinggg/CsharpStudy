using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.works
{
    public class work002
    {
        model.bank bankAccount;

        public void run()
        {
            Console.WriteLine("******안녕하세요. Road Bank입니다.*******\r\n"+
                "1: 계좌만들기 \r\n"+
                "2: 잔액조회 \r\n"+
                "3: 입금 \r\n"+
                "4: 출금 \r\n" +
                "0: 종료 \r\n" +
                "**************************************************");

            Start();

            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0) { break; }
                               
                switch (input)
                {
                    case 1:
                        Console.WriteLine("통장 고유 이름을 입력하세요");
                        string PrimaryName = Console.ReadLine();
                        Console.WriteLine("통장 개설자의 이름을 입력하세요");
                        string UserName = Console.ReadLine();

                        CreateBank(PrimaryName, UserName);
                        break;
                    case 2:
                        CheckMyMoney();
                        break;
                    case 3:
                        Console.WriteLine("입금할 금액을 입력하세요");
                        Deposit(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("출금할 금액을 입력하세요");
                        WithDraw(Convert.ToInt32(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("잘못입력하셨습니다");
                        break;
                }
            }
            Exit();
        }

        private void Start()
        {
            string logfilePath = string.Format(@"{0}\bankLog", Environment.CurrentDirectory);
            DirectoryInfo directory = new DirectoryInfo(logfilePath);

            if (directory.Exists && directory.GetFiles().Length > 0)
            {
                FileInfo file = directory.GetFiles()[0];
                string[] bankInfo = file.Name.Split('-');
                int money = 0;
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    money = Convert.ToInt32(sr.ReadLine());
                }
                bankAccount = new model.bank()
                {
                    PrimaryName = bankInfo[0],
                    UserName = bankInfo[1].Replace(".txt", ""),
                    Money = money
                };

                Console.WriteLine("이미 계좌가 있습니다.");
            }
        }

        private void CreateBank(string PrimaryName, string UserName)
        {
            bankAccount = new model.bank()
            {
                PrimaryName = PrimaryName,
                UserName = UserName,
                Money = 0
            };

            Console.WriteLine("'{0}'님의 '{1}'이 개설 되었습니다.",
                bankAccount.UserName, bankAccount.PrimaryName);
        }

        private void CheckMyMoney()
        {
            Console.WriteLine("잔액은 '{0}'원 입니다.", bankAccount.Money);
        }

        private void Deposit(int money)
        {
            bankAccount.Money += money;
            Console.WriteLine("입금 되었습니다.");
        }

        private void WithDraw (int money)
        {
            if (bankAccount.Money > money)
            {
                bankAccount.Money -= money;
                Console.WriteLine("출금 되었습니다");
            }
            else { Console.WriteLine("잔액이 부족합니다."); }
        }

        private void Exit()
        {
            if(bankAccount != null)
            {
                string directory = string.Format(@"\bankLog\", Environment.CurrentDirectory);
                string filename = string.Format(@"{0}-{1}.txt",
                    bankAccount.PrimaryName,
                    bankAccount.UserName);

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (StreamWriter sw = new StreamWriter(directory + filename, false))
                {
                    sw.WriteLine(bankAccount.Money);
                }
            }
            Console.WriteLine("감사합니다");
        }
    }
    
}

