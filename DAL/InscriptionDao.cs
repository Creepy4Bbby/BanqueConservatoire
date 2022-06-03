using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Gestion_conservatoire.Modele;

namespace Gestion_conservatoire.DAL
{
    class InscriptionDao
    {
        private ConnexionSql maConnexionsql;
        private MySqlCommand Ocom;

        //condition 
        public List<Inscription> getInscriptions(Adherent ad)
        {
            List<Inscription> listInscription = new List<Inscription>();
            try
            {

                maConnexionsql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionsql.openConnection();

                Ocom = maConnexionsql.reqExec("Select cours.id,cours.jourheure,inscription.idAdherent,inscription.Idcours,inscription.paye,instrument.id,instrument.nom,inscription.paye from inscription inner join cours on cours.id = inscription.idCours inner JOIN adherents on adherents.id = inscription.idAdherent INNER JOIN instrument on instrument.id = cours.id where adherents.id = " + ad.Num);

                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int courid = (int)reader1.GetValue(0);
                    string jourheure = (string)reader1.GetValue(1);
                    int idAdherent = (int)reader1.GetValue(2);
                    int idIns = (int)reader1.GetValue(3);
                    int paye = (int)reader1.GetValue(4);
                    int idInstrument = (int)reader1.GetValue(5);
                    string nomInstrument = (string)reader1.GetValue(6);
                    int solde = (int)reader1.GetValue(7);

                    Instrument unInstrument = new Instrument(idInstrument, nomInstrument);
                  

                    Cours unCours = new Cours(courid,jourheure,unInstrument);
                    

                    Inscription unInscription = new Inscription(ad,unCours,solde);
                    listInscription.Add(unInscription);                  

                }


                reader1.Close();
                maConnexionsql.closeConnection();

            }
            catch(Exception emp)
            {

                throw (emp);

            }
            return listInscription;
        
        
        }


      public void updateSolde(Inscription unInst)

        {
            try
            {
                maConnexionsql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionsql.openConnection();

                Ocom = maConnexionsql.reqExec("update inscription set paye = " + unInst.Solde + "where idAdherent = " + unInst.UnAdherent.Num + "and idCours =" + unInst.UnCours.Id);
                    }
            catch(Exception brout)
            {
                throw (brout);
            }

            }















    }
}
