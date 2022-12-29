using System;
using Microsoft.VisualBasic;

namespace RoadBook.CsharpBasic.Chapter05.work
{
    public class work02
    {
        Examples.service.BoardService _boardService;

        public void run()
        {
            Examples.model.Board board = new Examples.model.Board();
            Console.Write("제목을 입력하세요: ");
            board.Title = Console.ReadLine();
            Console.Write("내용을 입력하세요: ");
            board.Contents = Console.ReadLine();
            Console.Write("작성자 이름을 입력하세요: ");
            board.Writer = Console.ReadLine();

            _boardService = new Examples.service.BoardService(board);

            _boardService.Read();
        }
    }
}