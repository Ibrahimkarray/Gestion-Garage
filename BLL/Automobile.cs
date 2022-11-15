using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
        {
    public class Automobile
    {

        public string Annee { get => Annee; set => Annee = value; }
        public int Immatriculation { get => Immatriculation; set => Immatriculation = value; }
        
        public Automobile()
        {
        }

        public Automobile(string annee, int immatriculation )
        {
            this.Annee = annee;
            this.Immatriculation = immatriculation;
        }


        public override string ToString()
        {
            return "l'annee" +Annee + " Immatriculation" + Immatriculation ;
        }
    }
}
