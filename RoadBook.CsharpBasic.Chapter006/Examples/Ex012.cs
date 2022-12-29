using System;
using System.Collections;
namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    public class Ex012
    {
        public void run()
        {
            Hashtable hst = new Hashtable();

            hst.Add("korea", "한국");
            hst.Add("japan", "일본");
            hst.Add("brazil", "브라질");
            hst.Add("china", "중국");
            hst.Add("canada", "캐나다");
            hst.Add("america", "미국");
            hst.Add("spain", "스페인");


            while (true)
            {

                Console.Write("단어를 입력하세요(Q:종료) : ");
                string word = Console.ReadLine().ToLower();

                if (word == "q")
                {
                    break;
                }

                if (hst.Contains(word))
                {
                    Console.WriteLine("{0} : {1}", word, hst[word]);
                    Console.WriteLine("삭제하시겠습니까? \r\n" +
                                      "(1: Y/ 2:N)");
                    int del = Convert.ToInt32(Console.ReadLine());

                    switch (del)
                    {
                        case 1:
                            hst.Remove(word);
                            Console.WriteLine("삭제되었습니다");
                            break;
                        case 2:
                            Console.WriteLine("취소되었습니다");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("단어 검색결과가 없습니다\r\n" +
                                        "사전에 추가할까요?\r\n" +
                                        "(Y/N)");
                    string addWord = Console.ReadLine().ToUpper();

                    if (addWord == "Y")
                    {
                        Console.WriteLine("단어 뜻을 입력하세요: ");
                        string ans = Console.ReadLine();
                        hst.Add(word, ans);
                    }
                }
            }
        }
    }
}

