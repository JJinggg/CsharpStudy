using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
	public class Ex009
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

            Console.WriteLine(students.Where(s => s.Grade >= 3).Count());
        }
    }
}

