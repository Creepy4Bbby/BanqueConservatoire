using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
   public class Personne
    {
        private int num;
        private string nom;
        private string prenom;
        private string adresse;
        private List<Compte> comptes = new List<Compte>();

        public Personne(int num, string nom, string prenom, string ad)
        {
            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = ad;
        }

        public Personne()
        {
           
        }




        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int tel { get => tel; }

        public override string ToString()

        {

            return (this.tel + "   " + this.Nom + " " + this.prenom + " " + this.Adresse);
        }



    }
}
