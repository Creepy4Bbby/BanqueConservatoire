namespace Gestion_conservatoire.Modele
{
    public abstract class Personne
    {
        protected int id;
        protected string nom;
        protected string prenom;
        protected string adresse;
        protected string mail;
        protected string tel;

        public Personne(int id, string nom, string prenom, string ad, string mail, string tel)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = ad;
            this.mail = mail;
            this.tel = tel;
        }

        public Personne()
        {

        }

        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Mail { get => mail; }
        public string Tel { get => tel; set => tel = value; }

        public string Adresse { get => adresse; set => adresse = value; }
        public int Id { get => id; }

        public virtual string Description
        {

            get => this.id + "- " + this.nom + " " + this.prenom + " " + this.Adresse + " " + this.mail + " " + this.tel;
        }



    }
}
