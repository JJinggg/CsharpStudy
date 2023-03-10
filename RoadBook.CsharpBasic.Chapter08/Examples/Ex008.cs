using System;
using System.IO;
using Microsoft.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
	public class Ex008
	{
		private readonly string cuurrentDirectory = Environment.CurrentDirectory;
		private readonly string connectionStr =
			string.Format("Data Source = {0},{1}; Initial Catalog= {2}; User ID ={3}; Password = {4}; Trust Server Certificate=true;",
                "localhost", 1433, "testdb", "sa", "Infodba!@");

        public void run()
		{
			CheckedDirectory();
			TryConnectToDataBase();
		}

		private void CheckedDirectory()
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(cuurrentDirectory + @"\data");
			if (!directoryInfo.Exists) { directoryInfo.Create(); }
		}

		private void TryConnectToDataBase()
		{
			SqlConnection connection = new SqlConnection(connectionStr);

			string fileName = string.Format(@"\data\db{0}.log", DateTime.Now.ToString("yyyyMMddHHmmss"));

			using (StreamWriter sw = new StreamWriter(cuurrentDirectory+fileName, true))
			{
				sw.WriteLine("[{0}] 데이터베이스 연결 시도 ... ", DateTime.Now);
				connection.Open();
				sw.WriteLine("[{0}] 데이터베이스 연결 ok ...", DateTime.Now);

				Console.Write("삭제 할 유저의 아이디를 입력하세요:	");
				string userID = Console.ReadLine();
				string deleteSQL = string.Format("DELETE FROM TB_USER WHERE ID = '{0}'", userID);

				using (SqlCommand command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = deleteSQL;
					int activeNumber = command.ExecuteNonQuery();

					sw.WriteLine("영향 받은 데이터 : ", +activeNumber);
				}

				sw.WriteLine("[{0}] 데이터베이스 연결 끊기 시도 ...", DateTime.Now);
				connection.Close();
				sw.WriteLine("[{0}] 데이터베이스 연결 끊기 OK ... ", DateTime.Now);
			}

		}


    }
}

