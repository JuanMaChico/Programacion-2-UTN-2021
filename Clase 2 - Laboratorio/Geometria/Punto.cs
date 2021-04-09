using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto() 
        {
            this.x = 0;
            this.y = 0;
        }
        public Punto(int x):this()
        {
            this.x = x;
        }
        public Punto(int x, int y):this(x)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX ()
        {
            return this.x;
        }
        
        public int GetY()
        {
            return this.y;
        }


    }
}
