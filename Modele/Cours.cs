using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_conservatoire.Modele
{
    class Cours
    {
        private int id;
        private string jourHeure;
        private int nbPlace;
        private Adherent unAdherent;
        private Professeur unProfesseur;
        private Instrument unInstrument;

        public Cours(int id, string jourHeure, Instrument unInstrument)
        {
            this.id = id;
            this.jourHeure = jourHeure;
            this.unInstrument = unInstrument;
        }

        public string Date { get => jourHeure; }

        public Adherent UnAdherent { get => UnAdherent; }

        public Instrument UnIntrument { get => unInstrument; }

        //Methode qui appel l'id de cour
        public int Id { get => id; }

        public string Description
        {

            get => this.id + "- " + this.jourHeure + " " + this.nbPlace + " " + this.unAdherent + " " + this.unProfesseur + " " + this.unInstrument;
        }
    }
}
