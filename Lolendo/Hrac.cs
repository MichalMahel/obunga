using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lolendo
{
    public class Hrac : HerniPostava
    {
        private Oblicej Voblicej;
        private Vlasy Flasy;
        private BarvaVlasu BarvaFlasu;
        public int XP = 0;
        public string Specializace;
        
        public Hrac(Oblicej Voblicej, Vlasy Flasy, BarvaVlasu BarvaFlasu, string specializace) : base("Jmeno")
        {
            this.Voblicej = Voblicej;
            this.Flasy = Flasy;
            this.BarvaFlasu = BarvaFlasu;
            this.XP = 0;
            if (specializace == "Kouzelník" || specializace == "Berserker" || specializace=="Inženýr" || specializace  == "Cizák")
            {
                this.Specializace = specializace;


            }
            else
            {
                this.Specializace = null;
            }

        }
        public void PridejXP(int a)
        {
            this.XP += a;
            while (XP >= (100*base.level)*XP)
            {
                XP -= level * 100;
                level++;
            }
        }
        public override string ToString()
        {
            return base.ToString() + Voblicej + Flasy + BarvaFlasu + XP.ToString() + Specializace;
        }


    }
    public enum Oblicej { 
    VelkyNos,Usoplesk,MakeUp
    }
    public enum Vlasy
    {
        Drdol,Culik,Pleska
    }
    public enum BarvaVlasu
    {
        Kastanova,Blond,Brunet
    }

}
