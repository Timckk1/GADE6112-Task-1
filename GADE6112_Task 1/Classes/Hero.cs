using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1.Classes
{
    class Hero : Character
    {
        public Hero(int x, int y, int hp) : base(hp, 2, 10, x, y, 'H')
        {

        }

        public override Movement ReturnMove(Movement move = Movement.IDLE)
        {
            if (CharacterVisonArr[(int)move].GetType() != typeof(EmptyTile))
            {
                return Movement.IDLE;
            }

            switch (move)
            {
                case (Movement.UP): Y--; break;
                case (Movement.DOWN): Y++; break;
                case (Movement.LEFT): X--; break;
                case (Movement.RIGHT): X++; break;
            }
            return move;
        }

        public override string ToString()
        {
            return "Player Stats: " + Environment.NewLine + 
                   "HP: " + HP + "/" + MaxHP + Environment.NewLine + 
                   "Damage: " + Damage + Environment.NewLine + 
                   "[" + X + "," + Y + "]";
        }
    }
}
