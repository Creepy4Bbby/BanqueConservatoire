using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Gestion_conservatoire.Controleur;
using Gestion_conservatoire.Modele;

namespace Gestion_conservatoire
    
{
    [Serializable]
    public partial class Gestion : Form
    {
        Mgr monManager;

        private List<Adherent> lstAd = new List<Adherent>();
        Adherent Adherent_selected = new Adherent();
        private List<Inscription> lstIns = new List<Inscription>();
        public Gestion()
        {
            InitializeComponent();
            monManager = new Mgr();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            lstAd = monManager.chargementAdBD();
            rafraichirComboBox(0);
        }

        //Affiche les adhérents
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            btnSupp.Visible = false;

            int i = cBox.SelectedIndex;

            //MessageBox.Show(" i : " + i);

            if (i != -1)
            {
                Adherent ad = (Adherent)lstAd[i];

                lstIns = monManager.chargemenInBD(ad);

                if (lstIns.Count != 0) { rafraichirListBox(0); }

                else
                {
                    rafraichirListBox_Comptes_Vides();

                }


              

                //feu.Visible = true;
                //feu.BackColor = Color.Red;

            }
        }
        private void rafraichirListBox(int index)
        {

            lBox.DataSource = null;
            lBox.DataSource = lstIns;
            lBox.DisplayMember = "Description";
        }

        private void rafraichirComboBox(int index)
        {

            cBox.DataSource = null;
            // lBox.DataSource = lstcpt.Values.ToList();
            cBox.DataSource = lstAd;
            cBox.DisplayMember = "Description";
           // cBox.SelectedItem(index, true);

        }


            private void rafraichirListBox_Comptes_Vides()
        {
            lBox.DataSource = null;
            lBox.DisplayMember = "Description";
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lBox.SelectedIndex;
            
            if (i != -1)
            {
                Inscription inscription_adh_choisie = lstIns[i];

               
                int boolColor = inscription_adh_choisie.LimiteSolde;
                if (boolColor == 0)
                {
                    feu.BackColor = Color.Red;
                    feu.Visible = true;
                    //lbl_payee.Text = "INSCRIPTION NON PAYEE";
                    //lbl_payee.Visible = true;
                }
                else if (boolColor == 1)
                {
                    feu.BackColor = Color.Green;
                    feu.Visible = true;
                    //lbl_payee.Text = "INSCRIPTION PAYEE";
                    //lbl_payee.Visible = true;
                }
            }
            else
            {
                feu.Visible = false;
                //lbl_payee.Visible = false;
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = cBox.SelectedIndex;
            Adherent a = (Adherent)lstAd[i];

            FormAdherent fa = new FormAdherent(a);

            fa.ShowDialog();

            monManager.updateAdherent(a);

            lstAd = monManager.chargementAdBD();

            rafraichirComboBox(i);

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSupp.Visible = true;
            btnCrediter.Visible = false;
            textCrediter.Visible = false;

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            int i = cBox.SelectedIndex;
            Adherent ad = (Adherent)lstAd[i];
            try
            {
                monManager.deleteAdherent(ad);

                lstAd = monManager.chargementAdBD();

                rafraichirComboBox(i);
            }
            catch(Exception emp)
            {
                MessageBox.Show("Impossible il y a déjà une inscription");
            }
            

        }

        private void btnCrediter_Click(object sender, EventArgs e)
        {

            int i = lBox.SelectedIndex;

            //Inscription selectionnée
            Inscription  uneIns= lstIns[i];

            //Recupere le solde et transforme en int 
            uneIns.Crediter(Convert.ToInt32(textCrediter.Text));  
            
            ////J'apelle ma fonction
            monManager.updateSolde(uneIns);

            int j = cBox.SelectedIndex;
            if (j != -1)
            {
                Adherent ad = (Adherent)lstAd[j];

                lstIns = monManager.chargemenInBD(ad);

                rafraichirComboBox(j);


            }

        }

            private void crediterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCrediter.Visible = true;
            textCrediter.Visible = true;
            btnSupp.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
