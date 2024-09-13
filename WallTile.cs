using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevPOE
{
    public class WallTile : Tile
    {

        //fields
        Position pos;

        //properties
        //constructor

        public WallTile(Position pos) : base(pos)
        {
            
            this.pos = pos;
        }

        //methods
        public override char Display
        {
            get { return '█'; }
        }

    }
}
