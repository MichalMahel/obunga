using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lolendo
{
    public class Hrac : Hernipostava
    {
        public string Specializace;
        private Oblicej OblicejA;
        private Vlasy VlasyA;
        private barvaVlasu BarvaVlasuA;
        public int XP;
        public Hrac(string Jmeno, string Specializace, Oblicej Ob, Vlasy Vl, barvaVlasu Ba) : base("Name")
        {
            base.Jmeno = Jmeno;
            switch(Specializace)
            {
                case "Kouzelník":
                case "Berserker:":
                case "Inzenyr":
                case "Cizak": this.Specializace = Specializace; break;
                default: this.Specializace = "Kein"; break;
            }
            this.OblicejA = Ob;
            this.VlasyA = Vl;
            this.BarvaVlasuA = Ba;
            this.XP = 0;
        }
        public void PridejXP(int added)
        {
            this.XP += added;
             while(this.XP > base.Level *100)
            {
                this.XP -= (base.Level *100);
                base.Level++;
            }
        }
        public override string ToString()
        {
            string re = Jmeno + " " + X + " " + Y + " " + Level + " " + Specializace + " " + OblicejA + " " + VlasyA + " " + BarvaVlasuA + " " + XP;
            return re;
        }
    }
    public enum Oblicej
    {
        velkyNos,
        usoPlesk,
        makeUp
    }
    public enum Vlasy 
    { 
        drdol,
        culik,
        pleska
    }
    public enum barvaVlasu
    {
        cervena,
        cerna,
        hneda,
        modra,
        blond
    }

}
