using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.works
{
	public class work001
	{
        private readonly string cuurrentDirectory = Environment.CurrentDirectory;

        public void run()
		{

            DirectoryInfo directory =
                new DirectoryInfo(@"/Users/wonkeuncho/Desktop/바탕화면/dev/Csharp/MyFirstApp/RoadBook.CsharpBasic.Chapter08/bin/Release");

            FileInfo[] files = directory.GetFiles();

            for (int idx = 0; idx < files.Length; idx++)
            {
                FileInfo file = files[idx];
                Console.WriteLine(file.Name);
            }
        }
      
    }
}

