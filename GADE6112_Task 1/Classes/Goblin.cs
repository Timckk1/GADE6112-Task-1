using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1.Classes
{
    class Goblin : Enemy
    {
        Random rnd = new Random();
        public Goblin(int x, int y) : base(10, 1, x, y, 'G') 
        {

        }

        public Movement GetRandomMovement()
        {
            int Rmove = rnd.Next(1, 4);
            return (Movement)Rmove;
        }

        public override Movement ReturnMove(Movement move = Movement.IDLE)
        {
            bool validMove = false;
            Movement _movement = GetRandomMovement();


        }
    }
}
