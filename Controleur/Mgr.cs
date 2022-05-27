using Gestion_conservatoire.DAL;
using Gestion_conservatoire.Modele;
using System.Collections.Generic;

namespace Gestion_conservatoire.Controleur
{
    class Mgr
    {
        AdherentDao a = new AdherentDao();
        InscriptionDao c = new InscriptionDao();

        public List<Adherent> chargementAdBD()
        {
            return (a.getAdherents());
        }
        public List<Inscription> chargemenInBD(Adherent ad)
        {
            return (c.getInscriptions(ad));
        }
    }
}
