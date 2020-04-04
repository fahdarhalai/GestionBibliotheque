using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionLivres
{
    public partial class Gestionnaire : MetroFramework.Forms.MetroForm
    {
        private static Gestionnaire gestionnaire;
        private static Acceuil.Action _action;
        private static bool _sombre = false;
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\GestionLivres\GestionLivres\BiblioDB.mdf;Integrated Security=True");

        // Constructeur privé
        private Gestionnaire()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        // L'instanciation des objets se fait par la methode static GetGestionnaire qui implémente le concept de Singleton Pattern
        // Singleton Pattern : Creation d'une seule instance
        public static Gestionnaire GetGestionnaire
        {
            get
            {
                if(gestionnaire == null || gestionnaire.IsDisposed)
                {
                    gestionnaire = new Gestionnaire();
                }

                return gestionnaire;
            }
        }

        // Getters & Setters
        public static bool Sombre
        {
            get
            {
                return _sombre;
            }

            set
            {
                _sombre = value;
            }
        }

        public static Acceuil.Action Action
        {
            get
            {
                return _action;
            }

            set
            {
                _action = value;
            }
        }
        
        // Methode publique utilisé par les autres formes pour controller les propriétés du forme courant
        public void Gestionnaire_Load()
        {
            if (Gestionnaire.Sombre)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.pictureBoxDarkRetourner.Visible = true;
                this.pictureBoxLightRetourner.Visible = false;
                this.modeSombre.Checked = true;
            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                this.pictureBoxDarkRetourner.Visible = false;
                this.pictureBoxLightRetourner.Visible = true;
                this.modeSombre.Checked = false;
            }

            switch (Gestionnaire.Action)
            {
                case Acceuil.Action.LISTER:
                    this.ajouterLivre.Hide();
                    this.ajouterEtagere.Hide();
                    this.remplacerLivre.Hide();
                    this.remettreLivre.Hide();
                    this.retirerLivre.Hide();

                    this.lister.Lister_load();
                    this.lister.modeSombre_load();
                    this.lister.BringToFront();
                    this.lister.Show();
                    break;
                case Acceuil.Action.AJOUTER_LIVRE:
                    this.lister.Hide();
                    this.ajouterEtagere.Hide();
                    this.remplacerLivre.Hide();
                    this.remettreLivre.Hide();
                    this.retirerLivre.Hide();

                    this.ajouterLivre.AjouterLivre_Load();
                    this.ajouterLivre.BringToFront();
                    this.ajouterLivre.Show();
                    break;
                case Acceuil.Action.AJOUTER_ETAGERE:
                    this.lister.Hide();
                    this.ajouterLivre.Hide();
                    this.remplacerLivre.Hide();
                    this.remettreLivre.Hide();
                    this.retirerLivre.Hide();

                    this.ajouterEtagere.AjouterEtagere_Load();
                    this.ajouterEtagere.BringToFront();
                    this.ajouterEtagere.Show();
                    break;
                case Acceuil.Action.REMPLACER_LIVRE:
                    this.lister.Hide();
                    this.ajouterLivre.Hide();
                    this.ajouterEtagere.Hide();
                    this.remettreLivre.Hide();
                    this.retirerLivre.Hide();

                    this.remplacerLivre.RemplacerLivre_Load();
                    this.remplacerLivre.modeSombre_load();
                    this.remplacerLivre.BringToFront();
                    this.remplacerLivre.Show();
                    break;
                case Acceuil.Action.REMETTRE_LIVRE:
                    this.lister.Hide();
                    this.ajouterLivre.Hide();
                    this.ajouterEtagere.Hide();
                    this.remplacerLivre.Hide();
                    this.retirerLivre.Hide();

                    this.remettreLivre.RemettreLivre_load();
                    this.remettreLivre.BringToFront();
                    this.remettreLivre.Show();
                    break;
                case Acceuil.Action.RETIRER_LIVRE:
                    this.lister.Hide();
                    this.ajouterLivre.Hide();
                    this.ajouterEtagere.Hide();
                    this.remplacerLivre.Hide();
                    this.remettreLivre.Hide();

                    this.retirerLivre.RetirerLivre_Load();
                    this.retirerLivre.BringToFront();
                    this.retirerLivre.Show();
                    break;
            }
        }

        // Event Handlers
        private void modeSombre_CheckedChanged(object sender, EventArgs e)
        {
            Gestionnaire.Sombre = modeSombre.Checked;
            if (modeSombre.Checked)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.pictureBoxDarkRetourner.Visible = true;
                this.pictureBoxLightRetourner.Visible = false;
            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                this.pictureBoxDarkRetourner.Visible = false;
                this.pictureBoxLightRetourner.Visible = true;
            }
            this.lister.modeSombre_load();
            this.remplacerLivre.modeSombre_load();
        }

        private void pictureBoxLightRetourner_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = Acceuil.GetAcceuil;
            Acceuil.Sombre = Gestionnaire.Sombre;
            acceuil.Acceuil_Load();
            //acceuil.FormClosing += delegate { this.Show(); };
            acceuil.Show();
            this.Hide();
            acceuil.Closed += (s, args) => Environment.Exit(0);
        }

        private void pictureBoxDarkRetourner_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = Acceuil.GetAcceuil;
            Acceuil.Sombre = this.modeSombre.Checked;
            acceuil.Acceuil_Load();
            //acceuil.FormClosing += delegate { this.Show(); };
            acceuil.Show();
            this.Hide();
            acceuil.Closed += (s, args) => Environment.Exit(0);
        }
    }
}
