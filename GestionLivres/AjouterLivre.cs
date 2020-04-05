using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionLivres
{
    public partial class AjouterLivre : UserControl
    {
        public AjouterLivre()
        {
            InitializeComponent();
        }

        public void AjouterLivre_Load()
        {
            this.metroTextBoxCode.Text = "";
            this.metroTextBoxCode.Select();
            this.metroTextBoxTitre.Text = "";
            this.metroTextBoxPrix.Text = "";
        }

        public void modeSombre_load()
        {
            if (Gestionnaire.Sombre)
            {
                this.erreurCode.BackColor = Color.FromArgb(17, 17, 17);
                this.erreurPrix.BackColor = Color.FromArgb(17, 17, 17);
                this.erreurTitre.BackColor = Color.FromArgb(17, 17, 17);
            }
            else
            {
                this.erreurCode.BackColor = Color.White;
                this.erreurPrix.BackColor = Color.White;
                this.erreurTitre.BackColor = Color.White;
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.erreurCode.Visible = false;
            this.erreurTitre.Visible = false;
            this.erreurPrix.Visible = false;

            bool erreur = false;

            string code = metroTextBoxCode.Text;
            if(code == "")
            {
                this.erreurCode.Visible = true;
                erreur = true;
            }

            string titre = metroTextBoxTitre.Text;
            if (titre == "")
            {
                this.erreurTitre.Visible = true;
                erreur = true;
            }

            double prix = 0;
            if (metroTextBoxPrix.Text == "" || (prix = Convert.ToDouble(metroTextBoxPrix.Text.Replace('.', ','))) <= 0)
            {
                this.erreurPrix.Visible = true;
                erreur = true;
            }

            if (!erreur)
            {
                Livre livre = new Livre(code, titre, prix);
                Acceuil.livres.Add(livre);
                this.AjouterLivre_Load();
                MetroFramework.MetroMessageBox.Show(this, "Le livre est ajouté en succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void metroTextBoxPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if(e.KeyChar == ',' || e.KeyChar == '.')
            {
                if(metroTextBoxPrix.Text.IndexOf(',') > -1 || metroTextBoxPrix.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
