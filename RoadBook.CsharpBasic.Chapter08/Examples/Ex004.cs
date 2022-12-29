using System;
using System.IO;
using Microsoft.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex004
    {
        private readonly string currentDirectory = Environment.CurrentDirectory;
        
        private readonly string connetionStr =
                string.Format("Data Source ={0},{1}; Initial Catalog = {2} ; User ID ={3}; Password = {4}; Trust Server Certificate=true;",
                    "localhost", 1433, "testdb", "sa", "Infodba!@");
    

        public void run()
        {
            CheckedDirectory();
            try { TryConnectToDataBase(); }
            catch ( Exception e)
            {
                Console.WriteLine("error code : {0}", e.HResult);
                Console.WriteLine("error Message : {0}", e.Message);
            }
            Console.WriteLine("연결성공! DB log를 확인하세요");
        }

        private void CheckedDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"\data");
            if (!directoryInfo.Exists) { directoryInfo.Create(); }
        }
        private void TryConnectToDataBase()
        {
            SqlConnection connection = new SqlConnection(connetionStr);

            string fileName = string.Format(@"\data\db{0}.log",
                                            DateTime.Now.ToString("yyyyMMddHHmmss"));

            using (StreamWriter sw = new StreamWriter
                (currentDirectory + fileName, true))
            {
                sw.WriteLine("[{0}] 데이터베이스 연결 시도....", DateTime.Now);
                connection.Open();
                sw.WriteLine("[{0}] 데이터베이스 연결 OK...", DateTime.Now);

                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 시도....", DateTime.Now);
                connection.Close();
                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 OK...", DateTime.Now);

            }

        }
    }
}

