using System;
namespace RoadBook.CsharpBasic.Chapter05.Examples.service
{
    public class BoardService
    {
        model.Board board;

        public BoardService()
        {
            this.board = new model.Board();
        }

        public BoardService(model.Board board)
        {
            this.board = board;
        }

        public void Save(int number, string title, string content, string writer)
        {
            board.Number = number;
            board.Title = title;
            board.Contents = content;
            board.Writer = writer;
            board.CreateDate = DateTime.Now;
            board.UpdateDate = DateTime.Now;

            Console.WriteLine("게시물이 저장되었습니다");
        }

        public void Update(string title, string content, string writer)
        {
            board.Title = title;
            board.Contents = content;
            board.Writer = writer;

            Console.WriteLine("게시물이 수정되었습니다");
        }

        public void Delete()
        {
            board = null;

            Console.WriteLine("게시물이 삭제되었습니다");
        }
        public void Read()
        {
            if (board != null)
            {
                Console.WriteLine("{0}번 게시물", board.Number);
                Console.WriteLine("제목 : {0}", board.Title);
                Console.WriteLine("작성일 : {0}", board.CreateDate);
                Console.WriteLine("수정일 : {0}", board.UpdateDate);
                Console.WriteLine("글쓴이 : {0}", board.Writer);
                Console.WriteLine("내용 : {0}", board.Contents);
            }
            else
            {
                Console.WriteLine("게시물이 없습니다");
            }
        }
    }
}

