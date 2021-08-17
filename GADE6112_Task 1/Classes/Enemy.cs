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
        protected int EnDamage;
        protected int EnHP;
        protected int EnMaxHP;
        protected string EnSymbol;



        public Enemy(int x, int y, int damage, int hp, string symbol) : base(x, y, "")
        {
            EnDamage = damage;
            EnHP = hp;
            EnMaxHP = hp;
            EnSymbol = symbol;
            
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}
