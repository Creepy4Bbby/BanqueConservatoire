using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_conservatoire.Modele
{
   public class Adherent : Personne
    {
        int niveau;

        public Adherent(int id, string nom, string prenom, string mail, string tel, string ad) : base(id, nom, prenom, mail, tel, ad)

      //public Adherent(int id, string nom, string prenom, string mail, string tel, string ad, int niveau)
        {
            //this.niveau = niveau;
        }
        public Adherent()
        {

        }

        //methode appeler quand tu initiale un objet
        public int Num { get => id; }

        public int Niveau { get => niveau; set => niveau = value; }

        public override string Description
        {
            get => base.Description;/*+ " Niveau: " + this.niveau;*/
        }
    }
}
