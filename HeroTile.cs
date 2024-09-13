using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevPOE
{
    public class HeroTile : CharacterTile
    {

        //fields
        Position pos;
        char Char;

        //const
        public HeroTile(Position pos, int hitP, int attPower, bool isDead): base(pos)
        {

            this.pos = pos;
            if (isDead)
            {
                Char = 'x';
            }

            else
            {
                Char = '▼';
            }

        }
        //properties

        public override char Display
        {

            get { return Char; }

        }

        //methods

    }
}
