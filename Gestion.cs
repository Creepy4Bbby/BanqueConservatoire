using Gestion_conservatoire.Controleur;
using Gestion_conservatoire.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_conservatoire

{
    [Serializable]
    public partial class Gestion : Form
    {
        Mgr monManager;

        private List<Adherent> lstAd = new List<Adherent>();
        private List<Inscription> lstIns = new List<Inscription>();
        public Gestion()
        {
            InitializeComponent();
            monManager = new Mgr();
        }

        //Affichage adherents
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cBox.SelectedIndex;

            if (i != -1)
            {
                Adherent ad = (Adherent)lstAd[i];

               lstIns = monManager.chargemenInBD(ad);

                if (lstIns.Count != 0) { rafraichirListBox(0); }

//                else { rafraichirListBox_Comptes_Vides(); }

            }

        }

        //CREDITER
        private void bouton_Click(object sender, EventArgs e)
        {


            int j;

            j = lBox1.SelectedIndex;
            if (j != -1)
            {

                Compte c = lstcpt[j];


                int i;

                i = lBox.SelectedIndex;


                Client cl = lstclt[i];

                if (bouton.Text == "Valider le crédit")
                {

                    c.crediter(Convert.ToDouble(tb.Text));

                    monManager.updateSolde(c);

                }


                // On ne débite que si le retour de la méthode est à true sinon on affiche un message

                if (bouton.Text == "Valider le débit")
                {
                    try
                    {
                        c.debiter(Convert.ToDouble(tb.Text));

                        monManager.updateSolde(c);

                        tb.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }





                private void rafraichirListBox_Comptes_Vides()
        {

            lBox.DataSource = null;
            lBox.DisplayMember = "Description";
        }
        private void rafraichirComboBox(int index)
        {

            cBox.DataSource = null;
            //cBox.DataSource = lstcpt.Values.ToList();
            cBox.DataSource = lstAd.ToList();
            cBox.DisplayMember = "Description";

        }
        private void rafraichirListBox(int index)
        {

            lBox.DataSource = null;
            lBox.DataSource = lstIns;
            lBox.DisplayMember = "Description";
            lBox.SetSelected(index, true);

        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            lstAd = monManager.chargementAdBD();

            if (lstAd.Count != 0) { rafraichirComboBox(0); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
