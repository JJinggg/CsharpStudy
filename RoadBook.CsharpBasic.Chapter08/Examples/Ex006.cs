using System;
using Microsoft.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
	public class Ex006
	{
		private readonly string connetionStr =
			string.Format("Data Source={0},{1}; Initial Catalog = {2}; User Id = {3}; Password = {4}; Trust Server Certificate=true;",
				"localhost", 1433, "testdb", "sa", "Infodba!@");

		public void run()
		{
			string selectSQL = " SELECT ID, NAME, AGE, JOB FROM TB_USER";

			using(SqlConnection connection = new SqlConnection(connetionStr))
			{
				connection.Open();
				using(SqlCommand command = new SqlCommand(selectSQL, connection))
				{
                    SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
                        Console.WriteLine("회원 ID : {0}", reader["ID"]);
                        Console.WriteLine("회원 이름 : {0}", reader["NAME"]);
                        Console.WriteLine("회원 나이 : {0}", reader["AGE"]);
                        Console.WriteLine("회원 직업 : {0}", reader["JOB"]);
                        Console.WriteLine("=====");
                    }   
                }
				connection.Close();
            }
		}
	}
}

