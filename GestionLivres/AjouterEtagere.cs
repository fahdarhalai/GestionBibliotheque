using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionLivres
{
    public partial class AjouterEtagere : UserControl
    {
        public AjouterEtagere()
        {
            InitializeComponent();
        }

        public void AjouterEtagere_Load()
        {
            this.metroTextBoxEtagere.Text = "";
            this.metroTextBoxEtagere.Select();
        }

        public void modeSombre_load()
        {
            if (Gestionnaire.Sombre)
            {
                this.erreurEtagere.BackColor = Color.FromArgb(17, 17, 17);
            }
            else
            {
                this.erreurEtagere.BackColor = Color.White;
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.erreurEtagere.Visible = false;
            bool erreurInput = false;

            string numEtagere = this.metroTextBoxEtagere.Text;
            if (numEtagere == "")
            {
                this.erreurEtagere.Visible = true;
                erreurInput = true;
            }

            if (!erreurInput)
            {
                try
                {
                    Gestionnaire.con.Open();

                    // select etagere avec numEtagere
                    SqlDataReader sdr = Etagere.Select(0, numEtagere);
                    if (sdr.HasRows)
                    {
                        throw new Exception("Une étagère possédant le même numéro existe déjà");
                    }

                    // insert etagere
                    Etagere.Insert(numEtagere);

                    Etagere etagere = new Etagere(numEtagere);
                    Acceuil.etageres.Add(etagere);

                    this.AjouterEtagere_Load();
                    MetroFramework.MetroMessageBox.Show(this, "L'étagère est inserée dans la base de données en succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch(Exception ex)
                {
                    this.AjouterEtagere_Load();
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Gestionnaire.con.Close();
                }
            }
        }
    }
}
