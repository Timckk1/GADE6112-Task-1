using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1.Classes
{
   
    abstract class Tile
    {

        protected int X { get; set; }
        protected int Y { get; set; }

        

        public Tile (int x, int y, string symbol)
        {
            this.X = x;
            this.Y = y;
           
        }

        public enum TileType
        {
            HERO,
            ENEMY,         
            GOLD,
            WEAPON

        }

    }//Class Tile

    class Obstacle : Tile
    {
        public Obstacle(int x, int y) : base(x, y,"")
        {


        }
    }

    class EmptyTile : Tile
    {
        public EmptyTile(int x, int y) : base(x, y,"")
        {


        }
    }
}//NameSpace
