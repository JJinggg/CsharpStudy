using System;
namespace RoadBook.CsharpBasic.Chapter09.Examples
{
	public class Ex014
	{
		public void run()
		{
            List<Model.Student> students = new List<Model.Student>()
            {
                new Model.Student { Id = "S001", Name = "Dexter", Grade = 3, Major = "Software" },
                new Model.Student { Id = "D001", Name = "Ellin", Grade = 3, Major = "Design" },
                new Model.Student { Id = "S002", Name = "Jeffrey", Grade = 4, Major = "Software" },
                new Model.Student { Id = "D002", Name = "Sienna", Grade = 4, Major = "Design" },
                new Model.Student { Id = "S003", Name = "Pil", Grade = 4, Major = "Software" },
                new Model.Student { Id = "S006", Name = "Clint", Grade = 3, Major = "Software" },
                new Model.Student { Id = "S004", Name = "Khan", Grade = 2, Major = "Software" },
                new Model.Student { Id = "A001", Name = "Mike", Grade = 2, Major = "Advertisement" },
                new Model.Student { Id = "S005", Name = "Sven", Grade = 2, Major = "Software" },
                new Model.Student { Id = "T001", Name = "Peter", Grade = 1, Major = "Theater" },
            };

            #region 전공 별 key 값 나누기
            Dictionary<string, int> dicMajorCount = new Dictionary<string, int>();

            for (int idx =0; idx < students.Count; idx++)
            {
                if (!dicMajorCount.ContainsKey(students[idx].Major))
                {
                    dicMajorCount.Add(students[idx].Major, 1);
                }
                else
                {
                    dicMajorCount[students[idx].Major] = dicMajorCount[students[idx].Major] + 1;
                }
            }
            #endregion

            foreach (var key in dicMajorCount.Keys)
            {
                Console.WriteLine("{0} : {1}",key, dicMajorCount[key]);
            }
        }
    }
}

