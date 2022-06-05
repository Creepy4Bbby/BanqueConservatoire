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
        private int limiteSolde = 500;
        private string nomAd, prenomAd, dateCours, nomProf, prenomProf, nomInstrument;
        private int payer, nombrePlace;

        public Inscription(Adherent unAdherent, Cours unCours, int solde)
        {
            this.unAdherent = unAdherent;
            this.unCours = unCours;
            this.Solde = solde;
        }

    
        public void Crediter(int montant)
        {
            solde = montant + solde;
        }

        public void LimiteSolde(int m)
        {
            solde = m;
            m = 500;
        }


        //methode 
        public Adherent UnAdherent { get => unAdherent; }
        public Cours UnCours { get => unCours; }
        public int Solde { get => solde; set => solde = value; }

     

       public override string ToString()
        {
   
            return ("Cours : " + unCours.UnIntrument.NomInstru + "  | Date : " + unCours.Date + "   |   Reste à payé : " + Solde + "/" + limiteSolde);
        }




    }
}
