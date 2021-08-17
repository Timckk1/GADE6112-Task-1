using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1.Classes
{
    abstract class Character : Tile
    {
        protected int HP, MaxHP, Damage;

        public int _hp { get; set; }
        public int _maxHP { get; set; }
        public int _damage { get; set; }

        protected Tile[] CharacterVison;

        public enum Movement
        {
            IDLE,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        public Character(int x, int y,string symbol) : base(x, y,"")
        {


        }// constructor

        public virtual void Attack()
        {

        }

        public bool IsDead()
        {
            return true;
        }

        public virtual bool CheckRange()
        {
            return true;
        }

        private int DistanceTo()
        {
            return 0;
        }

        public void Move()
        {

        }

        public abstract Movement ReturnMove(Movement move = 0);
        public abstract override string ToString();


    }
}
