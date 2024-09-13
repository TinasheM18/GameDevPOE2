using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevPOE
{
    public abstract class Tile
    {

        //fields of Tile class
        private Position Pos;
        private int x, y;

        //constructor 
        public Tile(Position posTile)
        {
            this.Pos = posTile;
            x = Pos.X; y = Pos.Y;
        }

        //properties exposing values
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
        


        public abstract char Display
        {
            get;
        }

    }
}
