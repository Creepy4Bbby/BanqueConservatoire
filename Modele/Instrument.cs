namespace Gestion_conservatoire.Modele
{
    class Instrument
    {
        private int id;
        private string nomInstru;

        public Instrument(int id, string nomInstru)
        {
            this.id = id;
            this.nomInstru = nomInstru;
        }

        public string NomInstru { get => nomInstru; }
        public int Id { get => id; }

        public string Description
        {
            get => this.id + "- " + this.nomInstru;
        }
    }
}
