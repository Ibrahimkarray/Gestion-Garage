using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Voiture:Automobile
    {
        public string couleur { get; set; }
        public string marque { get; set; }
        public string typev { get; set; }

        public Voiture(string ann,int mat, string couleur, string marque, string typev):base(ann,mat)
        {
            this.couleur = couleur;
            this.marque = marque;
            this.typev = typev;
        }
        public override string ToString()
        {
            return base.ToString() + this.couleur + this.marque;
        }

    }
}
