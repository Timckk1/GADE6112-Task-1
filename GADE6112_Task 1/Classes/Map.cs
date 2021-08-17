using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1.Classes
{
    class Map
    {
        private int xWidth, yHeight;
        private Tile[,] mapArr;
        private Enemy[] enemyArr;

        Random rnd = new Random();

        Hero h = new Hero();
        
        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies)
        {
            minWidth = 10;
            maxWidth = 20;
            minHeight = 5;
            maxHeight = 10;
            xWidth = rnd.Next(minWidth, maxWidth);
            yHeight = rnd.Next(minHeight, maxHeight);
            mapArr = new Tile[xWidth, yHeight];
        }

        public void UpdateVison()
        {
            
        }

        private Tile Create(Tile.TileType type)
        {

        }
    }
}
