using System;
using Microsoft.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
	public class Ex005
	{
		private readonly string currentDirectory = Environment.CurrentDirectory;
		private readonly string connetionStr =
			string.Format("Data Source={0},{1}; Initial Catalog={2}; User ID ={3}; Password = {4}; Trust Server Certificate=true;",
				"localhost", 1433, "testdb", "sa", "Infodba!@");


		public void run()
		{
			CheckedDirectory();
			TryConnectToDataBase();
			Console.WriteLine("성공!");
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

			using (StreamWriter sw= new StreamWriter(currentDirectory + fileName, true))
			{
				sw.WriteLine("[{0}] 데이터베이스 연결 시도 ...", DateTime.Now);
				connection.Open();
                sw.WriteLine("[{0}] 데이터베이스 연결 OK...", DateTime.Now);

				Model.User user = SetUser();
				string insertSQL = string.Format("INSERT INTO TB_USER(ID, NAME, AGE, JOB) VALUES ('{0}',N'{1}','{2}',N'{3}')",
												user.userID,user.Name,user.Age,user.Job);

				using (SqlCommand command = new SqlCommand(insertSQL, connection) )
				{
                    int activeNumber = command.ExecuteNonQuery();
					
                    sw.WriteLine("영향 받은 데이터 : " + activeNumber);
                }

                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 시도....", DateTime.Now);
                connection.Close();
                sw.WriteLine("[{0}] 데이터베이스 연결 끊기 OK...", DateTime.Now);
            }
		}

		private Model.User SetUser()
		{
			Model.User user = new Model.User();

			bool validate = false;

			do
			{
				Console.Write("신규 회원의 아이디를 입력하세요 : ");
				user.userID = Console.ReadLine();
				Console.Write("신규 회원의 이름을 입력하세요 : ");
				user.Name = Console.ReadLine();
				Console.Write("신규 회원의 나이을 입력하세요 : ");
				user.Age = Convert.ToInt32(Console.ReadLine());
				Console.Write("신규 회원의 직어을 입력하세요 : ");
				user.Job = Console.ReadLine();

				Console.WriteLine("신규 회원 : {0} / {1} / {2} / {3} 이 맞습니까? (y/n)",
									user.userID, user.Name, user.Age, user.Job);
				validate = Console.ReadLine().ToLower() != "y";
			} while (validate);
			return user;
		}

    }
}

