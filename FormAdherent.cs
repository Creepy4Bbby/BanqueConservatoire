using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_conservatoire.Modele;
using Gestion_conservatoire.Controleur;

namespace Gestion_conservatoire
{
    public partial class FormAdherent : Form
    {
        private Adherent a;

        public FormAdherent(Adherent unAdherent)
        {
            InitializeComponent();
            this.a = unAdherent;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormAdherent_Load(object sender, EventArgs e)
        {
            txtId.Text = a.Num.ToString();
            txtNiveau.Text = a.Niveau.ToString();
            txtNom.Text = a.Nom;
            txtPrenom.Text = a.Prenom;
            txtAdresse.Text = a.Adresse;
            txtMail.Text = a.Mail;
            txtTel.Text = a.Tel;           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            a.Tel = txtTel.Text;
            a.Adresse = txtAdresse.Text;
            a.Niveau = Int16.Parse(txtNiveau.Text);

            this.Close();

        }
    }
}
