﻿using Gestion_conservatoire.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion_conservatoire.DAL
{
    class AdherentDao
    {
        private ConnexionSql maConnexionSql;


        private MySqlCommand Ocom;



        public Adherent getAdherent(int unNumero)
        {

            try
            {
                Adherent ad = new Adherent();



                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select p.id as idAdherent, p.nom as nomAdherent, p.prenom as prenomAdherent, " +
                    "p.tel as telAdherent, p.adresse as adresseAdherent, p.mail as mailAdherent, a.niveau as niveauAdherent  " +
                    "from adherents as a " +
                    "inner join personne as p on a.id = p.id where id =" + unNumero);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int id = (int)reader1.GetValue(0);
                    string nom = (string)reader1.GetValue(1);
                    string prenom = (string)reader1.GetValue(2);
                    string tel = (string)reader1.GetValue(3);
                    string adresse = (string)reader1.GetValue(4);
                    string mail = (string)reader1.GetValue(5);
                    int niveau = (int)reader1.GetValue(6);


                    ad = new Adherent(id, nom, prenom, adresse, mail, tel, niveau);


                }



                reader1.Close();

                maConnexionSql.closeConnection();


                return (ad);

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }


        public void updateAdherent(Adherent a)
        {

            try
            {


                // à compléter



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }


        public List<Adherent> getAdherents()
        {

            List<Adherent> lc = new List<Adherent>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select p.id as idAdherent, p.nom as nomAdherent, p.prenom as prenomAdherent, " +
                    "p.tel as telAdherent, p.adresse as adresseAdherent, p.mail as mailAdherent, a.niveau as niveauAdherent  " +
                    "from adherents as a " +
                    "inner join personne as p on a.id = p.id ");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Adherent a;




                while (reader.Read())
                {

                    int numero = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string tel = (string)reader.GetValue(3);
                    string adresse = (string)reader.GetValue(4);
                    string mail = (string)reader.GetValue(5);
                    int niveau = (int)reader.GetValue(6);

                    a = new Adherent(numero, nom, prenom, tel, adresse, mail, niveau);

                    lc.Add(a);


                }



                reader.Close();

                maConnexionSql.closeConnection();


            }




            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }

            return (lc);
        }
    }
}
