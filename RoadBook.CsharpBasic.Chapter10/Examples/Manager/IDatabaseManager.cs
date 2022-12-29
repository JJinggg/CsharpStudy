using System.Data;
using RoadBook.CsharpBasic.Chapter10.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter10.Examples.Manager
{
	public class IDatabaseManager
	{
		void Open(DatabaseInfo dbInfo);
		DataTable Select(string sql);
		int Insert(string sql);
		int Update(string sql);
		int Delete(string sql);
		void Close();
	}
}

