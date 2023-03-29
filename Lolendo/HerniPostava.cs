using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lolendo
{
    public abstract class HerniPostava
    {
        public string jmeno;
        protected int level;
        public int x, y;
        public HerniPostava(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public virtual void ZmenaPozice(int x1, int y1)
        {
            this.y = y1;
            this.x = x1;
        }

        public override string ToString()
        {
            return "Jméno: " + jmeno.ToString() + "level: " + level.ToString() + "x: " + x.ToString() + "y: " + y.ToString();
        }



    }
}
