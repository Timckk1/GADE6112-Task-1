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

        private Hero hero;

        public int XWidth
        {
            get { return xWidth; }
            set { xWidth = value; }
        }
        public int Yheight
        {
            get { return yHeight; }
            set { yHeight = value; }
        }

        public Tile[,] MapArr
        {
            get { return mapArr; }
            set { mapArr = value; }
        }
        public Enemy[] EnemyArr
        {
            get { return enemyArr; }
            set { enemyArr = value; }
        }

        public Hero Hero
        {
            get { return hero; }
            set { hero = value; }
        }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies)
        {
            XWidth = rnd.Next(minWidth, maxWidth);
            Yheight = rnd.Next(minHeight, maxHeight);

            mapArr = new Tile[XWidth, Yheight];
            enemyArr = new Enemy[numEnemies];

            for (int i = 0; i < XWidth; i++)//Empty Tiles
            {
                for (int j = 0; j < Yheight; j++)
                {
                    mapArr[i, j] = new EmptyTile(i, j);
                }
            }

            for (int i = 0; i < XWidth; i++) //Obstacles around map/ top and bottom
            {
                Tile topRow = new Obstacle(i, 0);
                mapArr[0, i] = topRow;
                Tile bottomRow = new Obstacle(i, Yheight);
                mapArr[i, Yheight] = bottomRow;
            }

            for (int i = 0; i < Yheight; i++) //Obstacles around map/ Left and Right
            {
                Tile leftCol = new Obstacle(0, i);
                mapArr[0, i] = leftCol;
                Tile rightCol = new Obstacle(XWidth, i);
                MapArr[XWidth, i] = rightCol;
            }

            Hero = (Hero)Create(Tile.TileType.HERO, -1);
            mapArr[Hero.X, Hero.Y] = Hero;

            for (int i = 0; i < numEnemies; i++)
            {
                enemyArr[i] = (Enemy)Create(Tile.TileType.ENEMY, i);

                mapArr[enemyArr[i].X, enemyArr[i].Y] = enemyArr[i];

                int rSpawn = rnd.Next(1,3);
                int x = rnd.Next(1, xWidth - 1);
                int y = rnd.Next(1, yHeight - 1);
            }
            UpdateVison();
        }
       
        public void UpdateVison()
        {
            Hero.CharacterVisonArr = new Tile[5];

            Hero.CharacterVisonArr[(int)Hero.Movement.IDLE] = null;
            Hero.CharacterVisonArr[(int)Hero.Movement.UP] = mapArr[Hero.X, Hero.Y -1];
            Hero.CharacterVisonArr[(int)Hero.Movement.DOWN] = mapArr[Hero.X, Hero.Y + 1];
            Hero.CharacterVisonArr[(int)Hero.Movement.LEFT] = mapArr[Hero.X -1, Hero.Y];
            Hero.CharacterVisonArr[(int)Hero.Movement.RIGHT] = mapArr[Hero.X +1, Hero.Y];

            for (int i = 0; i < enemyArr.Length; i++)
            {
                enemyArr[i].CharacterVisonArr = new Tile[5];

                enemyArr[i].CharacterVisonArr[(int)Hero.Movement.IDLE] = null;
                enemyArr[i].CharacterVisonArr[(int)Hero.Movement.UP] = mapArr[enemyArr[i].X, enemyArr[i].Y - 1];
                enemyArr[i].CharacterVisonArr[(int)Hero.Movement.DOWN] = mapArr[enemyArr[i].X, enemyArr[i].Y + 1];
                enemyArr[i].CharacterVisonArr[(int)Hero.Movement.LEFT] = mapArr[enemyArr[i].X - 1, enemyArr[i].Y];
                enemyArr[i].CharacterVisonArr[(int)Hero.Movement.RIGHT] = mapArr[enemyArr[i].X + 1, enemyArr[i].Y];
            }
        }
        
        private Tile Create(Tile.TileType type, int Index)
        {
            Random rndNum = new Random();


            if (Hero == null)
            {
                Hero = new Hero(0, 0, 10);//placeholder
            }

            int x = 0, y = 0;
            do
            {
                x = rndNum.Next(1, XWidth - 1);
                y = rndNum.Next(1, Yheight - 1);
            } while (MapContainsCharacterAt(x,y));

            if (type == 0)
            {
                return new Hero(x, y, 10);
            }
            else
            {
                return new Goblin(x, y);
            }
        }

        bool MapContainsCharacterAt(int x, int y)
        {
            if (Hero.X == x && Hero.Y == y)
            {
                return true;
            }

            for (int i = 0; i < enemyArr.Length; i++)
            {
                Tile Etile = enemyArr[i];
                if (Etile == null)
                {
                    return false;
                }
                if (Etile.X == x && Etile.Y == y)
                {
                    return true;
                }
            }

            return false;
        }
    }//Class
}//NS
