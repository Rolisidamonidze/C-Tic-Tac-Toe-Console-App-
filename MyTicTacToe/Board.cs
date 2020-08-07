using System;

namespace MyTicTacToe
{
    class Board
    {
        public State[,] states;
        public State Turn { get; private set; }

        public Board()
        {
            states = new State[3, 3];
            Turn = State.X;
        }

        public State GetState(Position position)
        {
            return states[position.Column, position.Row];
        }

        public bool SetState(Position position, State newState)
        {
            newState = Turn;
            if (states[position.Column, position.Row] != State.Empty)
            {
                return false;
            }

            states[position.Column, position.Row] = newState;
            ChangeTurn();
            return true;
        }

        private void ChangeTurn()
        {
            if (Turn == State.X)
            {
                Turn = State.O;
            }
            else
            {
                Turn = State.X;
            }
        }

    }
}
