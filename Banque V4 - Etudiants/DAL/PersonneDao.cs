using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Banque.Modele;

namespace Banque.DAL
{
    class PersonneDao 
    {
      

        private  ConnexionSql maConnexionSql;


        private   MySqlCommand Ocom;



        public  Personne getClient(int unNumero)
        {

            try
            {
                Personne cl = new Personne(); ;

                

               maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from client where numero = " + unNumero);


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int numero = (int)reader1.GetValue(0);
                    string nom = (string)reader1.GetValue(1);
                    string prenom = (string)reader1.GetValue(2);
                    string adresse = (string)reader1.GetValue(3);

                    cl = new Personne(numero, nom, prenom, adresse);

                    
                }



                reader1.Close();

                maConnexionSql.closeConnection();


                return (cl);

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }


        public void updateClient(Personne c)
        {

            try
            {

                Ocom = maConnexionSql.reqExec("Update client cl set cl.adresse = '" + c.Adresse + "' where cl.numero = " + c.Num);
                Ocom.ExecuteNonQuery();


            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }


        public List<Personne> getClients()
        {

            List<Personne> lc = new List<Personne>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from client");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Personne c;

               


                while (reader.Read())
                {

                    int numero = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string adresse = (string)reader.GetValue(3);

                    c = new Personne(numero, nom, prenom, adresse);

                    lc.Add(c);


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
