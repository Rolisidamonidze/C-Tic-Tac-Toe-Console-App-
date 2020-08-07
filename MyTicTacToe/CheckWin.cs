using System;
using System.Runtime.Serialization;

namespace MyTicTacToe
{
    class CheckWin
    {
        private States Winner { get; set; }
        public States WinChecker(Board board)
        {
            if (CheckDiagonal1(board, States.X) ||
                CheckDiagonal1(board, States.O) ||
                CheckDiagonal2(board, States.X) ||
                CheckDiagonal2(board, States.O))
            {
                return Winner;
            }

            for (int i = 0; i < 3; i++)
            {
                if (CheckHorizontal(board, States.X, i) ||
                    CheckVertical(board, States.X, i) ||
                    CheckVertical(board, States.O, i) ||
                    CheckHorizontal(board, States.O, i))
                {
                    return Winner;
                }
            }

            return States.Empty;
        }

        private bool CheckHorizontal(Board board, States state, int i)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!board.states[i, j].Equals(state))
                {
                    return false;
                }
            }
            Winner = state;
            return true;
        }

        private bool CheckVertical(Board board, States state, int i)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!board.states[j, i].Equals(state))
                {
                    return false;
                }
            }
            Winner = state;
            return true;
        }

        private bool CheckDiagonal1(Board board, States state)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!board.states[j, j].Equals(state))
                {
                    return false;
                }
            }
            Winner = state;
            return true;
        }

        private bool CheckDiagonal2(Board board, States state)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!board.states[j, 2 - j].Equals(state))
                {
                    return false;
                }
            }
            Winner = state;
            return true;
        }

        public bool IsDraw(Board board)
        {
            foreach (var state in board.states)
            {
                if (state == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
