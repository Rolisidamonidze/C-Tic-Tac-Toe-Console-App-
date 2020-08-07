using System;

namespace MyTicTacToe
{
    class Program
    {
        static void Main()
        {
            Board board = new Board();
            Player player = new Player();
            CheckWin check = new CheckWin();
            Render render = new Render();


            while (check.WinChecker(board) == States.Empty && !check.IsDraw(board))
            {
                render.RenderBoard(board);
                var position = player.PickPosition();
                board.SetState(position, board.Turn);

            }

            render.RenderBoard(board);

            if (check.WinChecker(board) != States.Empty)
            {
                Console.WriteLine($"{check.WinChecker(board)} wins!");
            }
            else if(check.IsDraw(board))
            {
                Console.WriteLine("It's a draw!");
            }

        }
    }
}
