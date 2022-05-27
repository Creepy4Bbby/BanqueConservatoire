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

        public Cours(int id, string jourHeure, int nbPlace, Adherent unAdherent, Professeur unProfesseur, Instrument unInstrument)
        {
            this.id = id;
            this.jourHeure = jourHeure;
            this.nbPlace = nbPlace;
            this.unAdherent = unAdherent;
            this.unProfesseur = unProfesseur;
            this.unInstrument = unInstrument;
        }

        public string Date { get => jourHeure; }
        public int NbPlace { get => nbPlace; }
        public Adherent UnAdherent { get => UnAdherent; }
        public Professeur UnProf { get => unProfesseur; }

        public Instrument UnIntrument { get => unInstrument; }
        public int Id { get => id; }

        public string Description
        {

            get => this.id + "- " + this.jourHeure + " " + this.nbPlace + " " + this.unAdherent + " " + this.unProfesseur + " " + this.unInstrument;
        }
    }
}
