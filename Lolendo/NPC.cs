using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lolendo
{
    public class NPC : HerniPostava
    {
        public Prace Dzob;
        public int Sila;
        public bool Boss;


        public NPC(Prace Arbaite, int Sila, bool Boss) : base("Jmeno")
        {
            this.Dzob = Arbaite;
            this.Sila = Sila;
            this.Boss = Boss;

        }
        public NPC(Prace Arbaite) : base("Jmeno")
        {
            this.Dzob = Arbaite;
            this.Boss = false;
        }
        public override void ZmenaPozice(int x1, int y1)
        {
            base.ZmenaPozice(x1, y1);
        }
        public override string ToString()
        {
            return base.ToString() + Dzob + Boss + Sila;
        }

    }
    public enum Prace
    {
        Obchonik, Nepritel, Obyvatel
    }
}
