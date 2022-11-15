using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Moto:Automobile
    {
        

        public Moto(string ann,int mat, int  cylindre, int vitesseMax):base(ann,mat)
        {
            this.Cylindre = cylindre;
            this.VitesseMax = vitesseMax;
        }

        public int Cylindre { get => Cylindre; set => Cylindre = value; }
        public int VitesseMax { get => VitesseMax; set => VitesseMax = value; }
        public override string ToString()
        {
            return base.ToString()+this.Cylindre+this.VitesseMax;
        }
        

    }
}
