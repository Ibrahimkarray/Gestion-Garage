using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Garage
    {
        public string adresse { get; set; }
        public List<Automobile> autos { get; set; }

        public Garage()
        {
            this.autos = new List<Automobile>();
            this.adresse = "ibrahim";
        }

        public Garage(string adresse, List<Automobile> autos)
        {
            this.adresse = adresse;
            this.autos = autos;
        }
        public string AddAuto(Automobile c)
        {
            try { this.autos.Add(c);
                return "added";
            }
            catch { return "probleme"; }
            

        }
        public void AfficherAutomobiles(SubType sousype) { 
            foreach (Automobile i in this.autos)
            { 
                if ((sousype == SubType.Voiture) & (i is Voiture ) )
                { Console.WriteLine(i.ToString()); }
                if((sousype == SubType.Moto) & (i is Voiture))
                { Console.WriteLine(i.ToString()); }
            } }
        public string DeleteAuto(int imm) { 
            foreach (Automobile i in this.autos)
            {if (i.Immatriculation == imm)
                { autos.Remove(i);
                    return "deleted";
                }
                
                    }
            return "deleted???";
        }
        public Automobile GetAuto(int imma)
        {
            foreach (Automobile i in this.autos)
            {
                if (i.Immatriculation == imma)
                { return i;}
            }
            return null;
        }
         public int GetIndexAuto(Automobile a1)
        {
            return autos.IndexOf(a1);
        }
        public enum SubType { Voiture,Moto}
    }
}
