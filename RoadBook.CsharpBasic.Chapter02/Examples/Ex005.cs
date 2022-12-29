using System;
namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex005
    {
        public void Run ()
        {
            object objHello = "Hello World";
            var vHello = "Hello World";
            dynamic dHello = "Hello World";

            bool isContainsWorld01 = objHello.ToString().Contains("Hello");                   
            bool isContainsWorld02 = vHello.ToString().Contains("Hello");
            bool isContainsWorld03 = dHello.ToString().Contains("Hello");

            Console.WriteLine("object 변수에 Hello가 포함되어있다 ? {0}", isContainsWorld01);
            Console.WriteLine("var 변수에 Hello가 포함되어있다 ? {0}", isContainsWorld02);
            Console.WriteLine("dynamic 변수에 Hello가 포함되어있다 ? {0}", isContainsWorld03);

        }
    }
}
