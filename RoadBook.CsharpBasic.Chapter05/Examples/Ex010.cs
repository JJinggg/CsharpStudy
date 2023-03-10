using System;
namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Ex010
    {
        public void run()
        {
            // 기본 생성자 이용
            int number = 1;
            string title = "첫 번째 게시글입니다";
            string contents = "첫 번째 공지사항입니다";
            string writer = "운영자";

            service.BoardService boardService = new service.BoardService();
            boardService.Save(number, title, contents, writer);
            boardService.Read();

            Console.WriteLine("=====");

            title = "첫 번째 게시글 수정!!";
            boardService.Update(title, contents, writer);
            boardService.Read();

            Console.WriteLine("=====");

            boardService.Delete();
            boardService.Read();

            Console.WriteLine("=====");

            // 생성자 오버로딩 이용
            model.Board board = new model.Board();
            board.Number = 2;
            board.Title = "두 번째 게시글입니다";
            board.Contents = "두 번째 공지사항입니다";
            board.Writer = "운영자";
            board.CreateDate = DateTime.Now;
            board.UpdateDate = DateTime.Now;

            service.BoardService anotherBoardService = new service.BoardService(board);
            anotherBoardService.Read();
        }
    }
}

