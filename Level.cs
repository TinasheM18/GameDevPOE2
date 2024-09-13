using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevPOE
{
    public class Level
    {

        //fields
        private int width = 0;
        private int height = 0;
        Position Pos;
        

        //properties
        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        

        //constructor
        public Level(int width, int height)
        {
            this.width = width;
            this.height = height;
            HeroTile hero;

            Tile[,] Tiles = new Tile[width, height];
        }

        public Level(int width, int height, HeroTile hero)
        {

        }

        public enum TileType
        {
            Empty,
            Wall,
            Hero, 
            Exit
        }

        TileType tileType;

        //methods
        private static Tile CreateTile(Enum tileType, Position pos)
        {
            tileType = tileType;

            switch (tileType)
            {
                case TileType.Wall:
                    break; 

                case TileType.Hero:
                    break;

                case TileType.Exit:
                    break;

                case TileType.Empty:

                    Position position = new Position(0, 0);
                    EmptyTile empty =  new EmptyTile(position);
                    break;

                default:
                break;
            }

            return tileType;

        }

        public void InitialiseTiles()
        {
            for (int i = 0; Tiles.getLength[0]; ++i)
            {
                if (tileType == TileType.Empty)
                {

                }

                else if(tileType == TileType.Wall)
                {

                }
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }

        public Position GetRandomEmptyPosition()
        {

            Position pos;

            return pos = new Position(0, 0);

        }

    }
}