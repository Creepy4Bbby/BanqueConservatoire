using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_conservatoire.DAL;
using Gestion_conservatoire.Modele;

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
        public void updateAdherent(Adherent ad)
        {
            a.updateAdherent(ad);
           
        }
        public void updateSolde(Inscription ins)
        {
            c.updateSolde(ins);

        }
        public void deleteAdherent(Adherent ad)
        {
            try
            {
                a.deleteAdherent(ad);
            }
            catch(Exception e)
            {
                throw (e);
            }
            
        }
    }
}
