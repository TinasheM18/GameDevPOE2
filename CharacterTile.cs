using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevPOE
{
    public abstract class CharacterTile : Tile
    {

        //fields
        int hitP =40, maxHitP, attPower=5;
        bool isDead = true;

        //constructor

        public CharacterTile(Position pos, int hitP, int attPower): base(pos)
        {
            this.hitP = hitP;
            maxHitP = hitP;
            this.attPower = attPower;
            Tile[] tile = new Tile[4];
        }

        //methods
        public void UpdateVision(Level level)
        {
            
        }

        public void TakeDamage(int damage)
        {
            if((hitP = hitP - damage) > 0)
            {
                hitP = hitP - damage;
                isDead = false;
            }

            else
            {

            }
        }

        public void Attack(char Target)
        {
            TakeDamage(attPower);
        }

        //properties
        public bool IsDead 
        {
            get { return isDead; } 
             
        }
    }
}
