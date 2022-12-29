using System;
using System.IO;
using Microsoft.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
	public class Ex007
	{
		private readonly string currentDirectory = Environment.CurrentDirectory;
		private readonly string connectionStr =
			string.Format("Data Source = {0},{1}; Initial Catalog= {2}; User ID ={3}; Password = {4}; Trust Server Certificate=true;",
				"localhost", 1433, "testdb", "sa", "Infodba!@");

		public void run()
		{
			CheckedDirectory();
			TryConnectToDataBse();
		}

		private void CheckedDirectory()
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"\data");
			if (!directoryInfo.Exists) { directoryInfo.Create(); }
		}
		private void TryConnectToDataBse()
		{
			SqlConnection connection = new SqlConnection(connectionStr);

            string fileName = string.Format(@"\data\db{0}.log",
                                            DateTime.Now.ToString("yyyyMMddHHmmss"));

	       using (StreamWriter sw = new StreamWriter
										(currentDirectory + fileName, true))
			{
				sw.WriteLine("[{0}] 데이터 베이스 연결 시도... ", DateTime.Now);
				connection.Open();
				sw.WriteLine("[{0}] 데이터 베이스 연결 OK... ", DateTime.Now);

				Model.User user = SetUser();
				string updateSQL = string.Format
									("UPDATE TB_USER SET NAME = N'{0}', AGE ='{1}', Job = N'{2}' WHERE ID = '{3}'",
					user.Name, user.Age, user.Job, user.userID);
				using (SqlCommand command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = updateSQL;
					int activeNumber = command.ExecuteNonQuery();
					sw.WriteLine("영향 받은 데이터 : ", +activeNumber);
				}

				sw.WriteLine("[{0}] 데이터베이스 연결 끊기 시도 ...", DateTime.Now);
				connection.Close();
				sw.WriteLine("[{0}] 데이터베이스 연결 끊기 OK ... ", DateTime.Now);
			}
		}


			private Model.User SetUser()
			{
				Model.User user = new Model.User();

				bool vaildate = false;
				do
				{
					Console.Write("정보 수정 할 회원의 아이디를 입력하세요 : ");
					user.userID = Console.ReadLine();
					Console.Write("회원의 이름를 입력하세요 : ");
					user.Name = Console.ReadLine();
					Console.Write("회원의 나이를 입력하세요 : ");
					user.Age = Convert.ToInt32(Console.ReadLine());
					Console.Write("회원의 직업을 입력하세요 : ");
					user.Job = Console.ReadLine();

					Console.WriteLine("수정 된 회원 : {0} / {1} / {2} / {3} 이 맞습니까? (y/n)",
						user.userID, user.Name, user.Age, user.Job);

					vaildate = Console.ReadLine().ToLower() != "y";
				} while (vaildate);

				return user;
			}
		
    }
}

