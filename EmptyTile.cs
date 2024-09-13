using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevPOE
{
    public class EmptyTile : Tile
    {

        //fields
        private Position PosEmptyT;

        //properties
        //constructor
        public EmptyTile(Position PosEmpty) : base(PosEmpty)
        {
            this.PosEmptyT = PosEmpty;
        }

        //methods
        public override char Display
        {
           get{ return '.';  }
        }

    }
}
