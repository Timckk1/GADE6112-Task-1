using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1.Classes
{
   
    abstract class Tile
    {
        public enum TileType
        {
            HERO,
            ENEMY,
            GOLD,
            WEAPON

        }

        protected int x;
        protected int y;
        protected char symbol;

        public int X
        {
            get { return x; }
            set { x = value; }

        }
        public int Y
        {
            get { return y; }
            set { y = value; }

        }
        public char Symbol
        {
            get { return symbol; }
            set { symbol = value; }

        }

        public Tile (int x, int y, char sym)
        {
            X = x;
            Y = y;
            symbol = sym;
        }
    }//Class Tile

    class Obstacle : Tile
    {
        public Obstacle(int x, int y) : base(x, y,'X')
        {


        }
    }

    class EmptyTile : Tile
    {
        public EmptyTile(int x, int y) : base(x, y, ' ')
        {


        }
    }
}//NameSpace
