using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyTicTacToe
{
    class Render
    {
        public void RenderBoard(Board board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board.states[i, j] == States.Empty)
                    {
                        Console.Write("|---|");
                    }
                    else
                    {
                        Console.Write($"|-{board.states[i, j]}-|");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
