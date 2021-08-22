using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1.Classes
{
    abstract class Enemy : Character
    {
        protected Random rnd = new Random();

        public Enemy(int hp, int damage, int x, int y, char symbol) : base(hp, damage, hp, x, y, symbol)
        {
            
        }

        public override string ToString()
        {
            return "at [" + X + "," + Y + "] (" + damage + ")";
        }
    }
}
