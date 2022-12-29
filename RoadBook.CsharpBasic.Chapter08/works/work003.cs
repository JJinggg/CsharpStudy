using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter08.works
{
    public class work003
    {
        private readonly string connectionStr =
            string.Format("Data Source = {0},{1}; Initial Catalog= {2}; User ID ={3}; Password = {4}; Trust Server Certificate=true;",
                "localhost", 1433, "testdb", "sa", "Infodba!@");

        SqlConnection connection;

        public void run()
        {
            Console.WriteLine("1 : 성적 입력 \r\n" +
                "2 : 성적 이의제기 \r\n" +
                "3 : 성적조회 \r\n" +
                "0 : 종료");

            connection = new SqlConnection(connectionStr);
            connection.Open();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0 ) { break; }

                switch (input)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        Modify();
                        break;
                    case 3:
                        Read();
                        break;
                    default:
                        Console.WriteLine("잘 못 입력하셨습니다.");
                        break;
                }
            }
            connection.Close();
        }

        private void Create()
        {
            Console.WriteLine("학생 이름을 입력하세요");
            string sName = Console.ReadLine();
            Console.WriteLine("학생 학번을 입력하세요");
            string sID = (Console.ReadLine());
            Console.WriteLine("과목명을 입력하세요");
            string subject = Console.ReadLine();
            Console.WriteLine("점수를 입력하세요");
            int score = Convert.ToInt32(Console.ReadLine());

            string insertSql = string.Format("INSERT INTO TB_GRADE (S_NAME, S_ID, Subject, Score) VALUES ( N'{0}', N'{1}', N'{2}', '{3}')",
                                            sName, sID, subject, score);

            using (SqlCommand command = new SqlCommand(insertSql, connection))
            {
                int activeNumber = command.ExecuteNonQuery();
                Console.WriteLine("영향 받은 데이터 : " + activeNumber);
            }
        }

        private void Modify()
        {
            Console.WriteLine("학생 학번을 입력하세요");
            int sID = Convert.ToInt32(Console.ReadLine());

            string selectSql = string.Format("SELECT SUBJECT, ScoRE FROM TB_GRADE WHERE S_ID = '{0}'",
                                                sID);
            using(SqlCommand command = new SqlCommand(selectSql, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("과목명 : {0} \r\n" +
                                      "점수 : {1} \r\n" +
                                      "===========",
                                      reader["Subject"], reader["Score"]);
                } reader.Close();
            }

            Console.WriteLine("수정할 과목명을 입력하세요");
            string subject = Console.ReadLine();
            Console.WriteLine("점수를 입력하세요");
            int score = Convert.ToInt32(Console.ReadLine());

            string updateSql = string.Format("UPDATE TB_GRADE SET SCORE='{0}' WHERE S_ID='{1}' AND SUBJECT= N'{2}' ",
                                                score, sID, subject);

            using (SqlCommand command = new SqlCommand(updateSql, connection))
            {
                int activeNumber = command.ExecuteNonQuery();
                Console.WriteLine("영향 받은 데이터 : " + activeNumber);
            }
        }

        private void Read()
        {
            string selectSQL = string.Format(" SELECT S_NAME, S_ID, SUBJECT, SCORE FROM TB_GRADE ");

            using (SqlCommand command = new SqlCommand(selectSQL, connection))
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("학생이름 : {0}", reader["S_NAME"]);
                    Console.WriteLine("학생학번 : {0}", reader["S_ID"]);
                    Console.WriteLine("과목명 : {0}", reader["SUBJECT"]);
                    Console.WriteLine("점수 : {0}", reader["SCORE"]);
                    Console.WriteLine("=====");
                }
                reader.Close();
            }
        }
    }
}