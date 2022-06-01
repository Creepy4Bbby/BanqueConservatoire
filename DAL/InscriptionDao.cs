﻿using System;
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


        public List<Inscription> getInscriptions(Adherent ad)
        {
            List<Inscription> listInscription = new List<Inscription>();
            try
            {

                maConnexionsql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionsql.openConnection();
                //Selection les inscription
                Ocom = maConnexionsql.reqExec("select pers.nom as nomAd, pers.prenom as prenomAd, c.jourheure as dateCours, " +
                    "pers1.nom as nomProf, pers1.prenom as prenomProf, c.nbPlace as nPlace, i.nom as nomInstrument, insc.paye as solde " +
                    "from inscription as insc inner join adherents as a on a.id = insc.idAdherent " +
                    "inner join cours as c on c.id = insc.idCours " +
                    "inner join professeurs as p on p.id = c.idProfesseur " +
                    "inner join personne as pers on pers.id = a.id " +
                    "inner join personne as pers1 on pers1.id = p.id " +
                    "inner join instrument as i on i.id = c.idInstrument " +
                    "where idAdherent = " + ad.Num);

                MySqlDataReader reader1 = Ocom.ExecuteReader();
                Inscription unInscription;

                while (reader1.Read())
                {

                    string nomAd = (string)reader1.GetValue(0);
                    string prenomAd = (string)reader1.GetValue(1);
                    string dateCours = (string)reader1.GetValue(2);
                    string nomProf = (string)reader1.GetValue(3);
                    string prenomProf = (string)reader1.GetValue(4);
                    int nombrePlace = (int)reader1.GetValue(5);
                    string nomInstrument = (string)reader1.GetValue(6);
                    int solde = (int)reader1.GetValue(7);

                    unInscription = new Inscription(nomAd, prenomAd, dateCours, nomProf, prenomProf, nombrePlace, nomInstrument, solde);
                    listInscription.Add(unInscription);

                }

                reader1.Close();
                maConnexionsql.closeConnection();

            }
            catch (Exception emp)
            {

                throw (emp);

            }
            return listInscription;


        }

    }
}
