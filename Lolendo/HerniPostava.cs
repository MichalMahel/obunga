using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lolendo
{
    public abstract class Hernipostava
    {
        public string Jmeno;
        public int X, Y;
        public int Level;
        public Hernipostava(string jmeno)
        {
            this.Jmeno = jmeno;
            if (Jmeno.Length > 10)
            {
                Jmeno = "null";
            }
            X = 0;
            Y = 0;
            Level = 1;
        }
        public virtual void ZmenaPozice(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            string re = Jmeno + " " + X + " " + Y + " " +Level;
            return re;
        }
    }
}
