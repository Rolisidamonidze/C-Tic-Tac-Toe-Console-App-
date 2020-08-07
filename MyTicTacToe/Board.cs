using System;

namespace MyTicTacToe
{
    class Board
    {
        public States[,] states;
        public States Turn { get; private set; }

        public Board()
        {
            states = new States[3, 3];
            Turn = States.X;
        }

        public States GetState(Position position)
        {
            return states[position.Column, position.Row];
        }

        public bool SetState(Position position, States newState)
        {
            newState = Turn;
            if (states[position.Column, position.Row] != States.Empty)
            {
                return false;
            }

            states[position.Column, position.Row] = newState;
            ChangeTurn();
            return true;
        }

        private void ChangeTurn()
        {
            if (Turn == States.X)
            {
                Turn = States.O;
            }
            else
            {
                Turn = States.X;
            }
        }

    }
}
