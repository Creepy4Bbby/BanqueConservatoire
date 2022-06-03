using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_conservatoire.Modele
{ 
    class Inscription
    {
        private Adherent unAdherent;
        private Cours unCours;
        private int solde;
        private string nomAd, prenomAd, dateCours, nomProf, prenomProf, nomInstrument;
        private int payer, nombrePlace;

        public Inscription(Adherent unAdherent, Cours unCours, int solde)
        {
            this.unAdherent = unAdherent;
            this.unCours = unCours;
            this.Solde = solde;
        }
        public Adherent UnAdherent { get => unAdherent; }
        public Cours UnCours { get => unCours; }
        public int Solde { get => solde; set => solde = value; }

        public override string ToString()
        {
            return (unCours.UnIntrument.NomInstru + " | " + unCours.Date + " | " + Solde);
        }
        
        
    }
}
