using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevPOE
{
    public class Position
    {
        //Fields of Position class for X & Y values
        private int x, y;//x and y integer fields

        //Constructor of Position class acceping parameters
        public Position(int x, int y)
        {
            this.x = x; this.y = y;
        }

        // Properties of Position Class
        public int X 
        {

            get { return x; }

            set { x = value;  }
        
        }

        public int Y 
        {

            get { return y; }

            set { y = value; }

        }
    }
}
