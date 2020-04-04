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
    public partial class Acceuil : MetroFramework.Forms.MetroForm
    {
        private static Acceuil acceuil;
        private static bool _sombre = false;
        //private static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\GestionLivres\GestionLivres\BiblioDB.mdf;Integrated Security=True");
        public static List<Livre> livres = new List<Livre>();
        public static List<Etagere> etageres = new List<Etagere>();

        public enum Action
        {
            LISTER,
            AJOUTER_LIVRE,
            AJOUTER_ETAGERE,
            REMPLACER_LIVRE,
            REMETTRE_LIVRE,
            RETIRER_LIVRE
        }
        
        public Acceuil()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        // L'instanciation des objets se fait par la methode static GetAcceuil qui implémente le concept de Singleton Pattern
        // Singleton Pattern : Creation d'une seule instance
        public static Acceuil GetAcceuil
        {
            get
            {
                if(acceuil == null || acceuil.IsDisposed)
                {
                    acceuil = new Acceuil();
                }

                return acceuil;
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

        // Methode publique utilisé par les autres formes pour controller les propriétés du forme courant
        public void Acceuil_Load()
        {
            if (Acceuil.Sombre)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.modeSombre.Checked = true;
            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                this.modeSombre.Checked = false;
            }
        }

        // Event Handlers
        private void modeSombre_CheckedChanged(object sender, EventArgs e)
        {
            Acceuil.Sombre = modeSombre.Checked;
            if (modeSombre.Checked)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        private void metroTileLister_Click(object sender, EventArgs e)
        {
            Gestionnaire gestionnaire = Gestionnaire.GetGestionnaire;
            Gestionnaire.Sombre = Acceuil.Sombre;
            Gestionnaire.Action = Action.LISTER;
            gestionnaire.Gestionnaire_Load();
            //gestionnaire.FormClosing += delegate { this.Show(); };
            gestionnaire.Show();
            this.Hide();
            gestionnaire.Closed += (s, args) => Environment.Exit(0);
        }

        private void metroTileAjouterLivre_Click(object sender, EventArgs e)
        {
            Gestionnaire gestionnaire = Gestionnaire.GetGestionnaire;
            Gestionnaire.Sombre = Acceuil.Sombre;
            Gestionnaire.Action = Action.AJOUTER_LIVRE;
            gestionnaire.Gestionnaire_Load();
            //gestionnaire.FormClosing += delegate { this.Show(); };
            gestionnaire.Show();
            this.Hide();
            gestionnaire.Closed += (s, args) => Environment.Exit(0);
        }

        private void metroTileAjouterEtagere_Click(object sender, EventArgs e)
        {
            Gestionnaire gestionnaire = Gestionnaire.GetGestionnaire;
            Gestionnaire.Sombre = Acceuil.Sombre;
            Gestionnaire.Action = Action.AJOUTER_ETAGERE;
            gestionnaire.Gestionnaire_Load();
            //gestionnaire.FormClosing += delegate { this.Show(); };
            gestionnaire.Show();
            this.Hide();
            gestionnaire.Closed += (s, args) => Environment.Exit(0);
        }

        private void metroTileRemplacerLivre_Click(object sender, EventArgs e)
        {
            Gestionnaire gestionnaire = Gestionnaire.GetGestionnaire;
            Gestionnaire.Sombre = Acceuil.Sombre;
            Gestionnaire.Action = Action.REMPLACER_LIVRE;
            gestionnaire.Gestionnaire_Load();
            //gestionnaire.FormClosing += delegate { this.Show(); };
            gestionnaire.Show();
            this.Hide();
            gestionnaire.Closed += (s, args) => Environment.Exit(0);
        }

        private void metroTileRemettreLivre_Click(object sender, EventArgs e)
        {
            Gestionnaire gestionnaire = Gestionnaire.GetGestionnaire;
            Gestionnaire.Sombre = Acceuil.Sombre;
            Gestionnaire.Action = Action.REMETTRE_LIVRE;
            gestionnaire.Gestionnaire_Load();
            //gestionnaire.FormClosing += delegate { this.Show(); };
            gestionnaire.Show();
            this.Hide();
            gestionnaire.Closed += (s, args) => Environment.Exit(0);
        }

        private void metroTileRetirerLivre_Click(object sender, EventArgs e)
        {
            Gestionnaire gestionnaire = Gestionnaire.GetGestionnaire;
            Gestionnaire.Sombre = Acceuil.Sombre;
            Gestionnaire.Action = Action.RETIRER_LIVRE;
            gestionnaire.Gestionnaire_Load();
            //gestionnaire.FormClosing += delegate { this.Show(); };
            gestionnaire.Show();
            this.Hide();
            gestionnaire.Closed += (s, args) => Environment.Exit(0);
        }

        private void metroTileQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
