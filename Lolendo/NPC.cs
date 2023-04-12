using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lolendo
{
    public class NPC : Hernipostava
    {
        public NPCType Type;
        public int Sila;
        public bool Boss;
        public NPC(NPCType NT, int Sila) : base("Name")
        {
            this.Type = NT;
            this.Sila = Sila;
            Boss = true;
        }
        public NPC(NPCType NT) : base("Name")
        {
            this.Type = NT;
            Boss = false;
        }
        public override void ZmenaPozice(int x, int y)
        {
            base.X = x;
            base.Y = y;
        }
        public enum NPCType
        {
            Obchodnik,
            Nepritel,
            Obyvatel
        }
    }
}
