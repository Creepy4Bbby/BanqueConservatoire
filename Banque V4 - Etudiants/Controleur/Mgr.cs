using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banque.DAL;
using Banque.Modele;

namespace Banque.Controleur
{
    class Mgr
    {

        CompteDao cd = new CompteDao();
        PersonneDao cld = new PersonneDao();

    
      

        public List<Personne> chargementClBD()
        {

            return(cld.getClients());

        }

        public List<Compte> chargementCBD( Personne cl)
        {

            return cd.getComptes(cl);

        }

        

        public void updateClient(Personne c)
        {

            cld.updateClient(c);

        }

        public void updateSolde(Compte c)
        {

            cd.updateSolde(c);

        }

        public void updateDecouvert(CompteCourant c)
        {

            cd.updateDecouvert(c);

        }


    }
}
