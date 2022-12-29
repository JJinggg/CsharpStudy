using System;
using Microsoft.Data.SqlClient;
using RoadBook.CsharpBasic.Chapter10.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter10.Examples.Manager
{
	public class MsSqlManager : IDatabaseManager
	{
		SqlConnection connection = null;

		public void Open(DatabaseInfo dbInfo)
		{
			string conStr = string.Format("Data Source = {0},{1}; Initial Catalog ={2}; User ID ={3}; Password{4}",
				dbInfo.Ip,
				dbInfo.Port,
				dbInfo.Name,
				dbInfo.UserId,
				dbInfo.UserPassword);
			connection = new SqlConnection(conStr);
			connection.Open();
		}
	}
}

