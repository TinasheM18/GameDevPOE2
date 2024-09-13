using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevPOE
{
    public class ExitTile : Tile
    {

        public ExitTile(Position pos) : base(pos)
        {

        }

        public override char Display
        {

            get{return '▒';}

        }
    }
}
