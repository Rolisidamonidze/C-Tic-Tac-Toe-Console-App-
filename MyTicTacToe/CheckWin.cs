using System;
using System.Runtime.Serialization;

namespace MyTicTacToe
{
    class CheckWin
    {
        public State WinChecker(Board board)
        {
            if (board.states[0, 0] == State.X &&
                board.states[0, 1] == State.X &&
                board.states[0, 2] == State.X)
            {
                return State.X;
            }

            if (board.states[0, 0] == State.O &&
                board.states[0, 1] == State.O &&
                board.states[0, 2] == State.O)
            {
                return State.O;
            }

            if (board.states[1, 0] == State.X &&
                board.states[1, 1] == State.X &&
                board.states[1, 2] == State.X)
            {
                return State.X;
            }

            if (board.states[1, 0] == State.O &&
                board.states[1, 1] == State.O &&
                board.states[1, 2] == State.O)
            {
                return State.O;
            }

            if (board.states[2, 0] == State.X &&
                board.states[2, 1] == State.X &&
                board.states[2, 2] == State.X)
            {
                return State.X;
            }

            if (board.states[2, 0] == State.O &&
                board.states[2, 1] == State.O &&
                board.states[2, 2] == State.O)
            {
                return State.O;
            }

            if (board.states[0, 0] == State.X &&
                board.states[1, 1] == State.X &&
                board.states[2, 2] == State.X)
            {
                return State.X;
            }

            if (board.states[0, 0] == State.O &&
                board.states[1, 1] == State.O &&
                board.states[2, 2] == State.O)
            {
                return State.O;
            }

            return State.Empty;
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
