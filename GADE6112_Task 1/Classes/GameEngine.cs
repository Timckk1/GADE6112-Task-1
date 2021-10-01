using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_1.Classes
{
    class GameEngine
    {
        private Map map;
        private MapForm mainForm;
        public Map CreateMap
        {
            get { return map; }
            set { map = value; }
        }

        public GameEngine (MapForm form, int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyNum)
        {
            mainForm = form;
            CreateMap = new Map(minWidth, maxWidth, minHeight, maxHeight, enemyNum);
        }

        public bool MovePlayer(Character.Movement direction)
        {
            int x = CreateMap.Hero.X;
            int y = CreateMap.Hero.Y;
            CreateMap.MapArr[x, y] = new EmptyTile(x, y);

            switch(direction)
            {
                case Character.Movement.IDLE:
                    break;
                case Character.Movement.UP:
                    if (CreateMap.Hero.CharacterVisonArr[(int)Hero.Movement.UP].GetType() != typeof(EmptyTile)) break;
                    CreateMap.Hero.X = x;
                    CreateMap.Hero.Y = y - 1;
                    CreateMap.MapArr[x, y + 1] = CreateMap.Hero;
                    break;
                case Character.Movement.DOWN:
                    if (CreateMap.Hero.CharacterVisonArr[(int)Hero.Movement.DOWN].GetType() != typeof(EmptyTile)) break;
                    CreateMap.Hero.X = x;
                    CreateMap.Hero.Y = y + 1;
                    CreateMap.MapArr[x, y + 1] = CreateMap.Hero;
                    break;
                case Character.Movement.RIGHT:
                    if (CreateMap.Hero.CharacterVisonArr[(int)Hero.Movement.RIGHT].GetType() != typeof(EmptyTile)) break;
                    CreateMap.Hero.X = x + 1;
                    CreateMap.Hero.Y = y;
                    CreateMap.MapArr[x + 1, y] = CreateMap.Hero;
                    break;
                case Character.Movement.LEFT:
                    if (CreateMap.Hero.CharacterVisonArr[(int)Hero.Movement.LEFT].GetType() != typeof(EmptyTile)) break;
                    CreateMap.Hero.X = x - 1;
                    CreateMap.Hero.Y = y;
                    CreateMap.MapArr[x - 1, y] = CreateMap.Hero;
                    break;
                default:
                    break;
            }
            CreateMap.MapArr[x, y - 1] = CreateMap.Hero;
            CreateMap.UpdateVison();

            return false;
        }//MovePLayter

        public void Attack (Enemy enemy)
        {
            enemy.HP -= CreateMap.Hero.Damage;

            if (enemy.HP < 1)
            {
                CreateMap.MapArr[enemy.X, enemy.Y] = new EmptyTile(enemy.X, enemy.Y);
            }
        }
        internal void AttackBack(Enemy enemy)
        {
            CreateMap.Hero.HP -= enemy.Damage;

            if (CreateMap.Hero.HP < 1)
            {

            }
        }
    }
}
