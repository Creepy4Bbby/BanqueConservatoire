namespace Gestion_conservatoire.Modele
{
    class Adherent : Personne
    {
        int niveau;
        public Adherent(int id, string nom, string prenom, string ad, string mail, string tel, int niveau) : base(id, nom, prenom, ad, mail, tel)
        {
            this.niveau = niveau;
        }
        public Adherent()
        {

        }
        public int Num { get => id; }

        public int Niveau { get => niveau; }

        public override string Description
        {
            get => base.Description + " Niveau: " + this.niveau;
        }
    }
}
