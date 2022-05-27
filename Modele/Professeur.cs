using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_conservatoire.Modele
{
    class Professeur : Personne
    {
        double salaire;
        public Professeur(int id, string nom, string prenom, string ad, string mail, string tel, double salaire) : base(id, nom, prenom, ad, mail, tel)
        {
            this.salaire = salaire;
        }

        public double Salaire
        {
            get => salaire;
        }

        public override string Description
        {
            get => base.Description + " Salaire: " + this.salaire;
        }
    }
}
