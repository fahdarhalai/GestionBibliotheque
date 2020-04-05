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
    public partial class RemettreLivre : UserControl
    {
        public RemettreLivre()
        {
            InitializeComponent();
        }

        public void RemettreLivre_load()
        {
            metroComboBoxCode.Items.Clear();
            metroComboBoxEtagere.Items.Clear();

            foreach (Livre livre in Acceuil.livres)
            {
                metroComboBoxCode.Items.Add(livre.Code);
            }

            try
            {
                Gestionnaire.con.Open();
                SqlDataReader sdr;

                // select etageres
                sdr = Etagere.Select();
                while (sdr.Read())
                {
                    metroComboBoxEtagere.Items.Add(sdr["numero"]);
                }
                sdr.Close();
            }catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Gestionnaire.con.Close();
            }
        }

        public void modeSombre_load()
        {
            if (Gestionnaire.Sombre)
            {
                this.erreurCode.BackColor = Color.FromArgb(17, 17, 17);
                this.erreurEtagere.BackColor = Color.FromArgb(17, 17, 17);
            }
            else
            {
                this.erreurCode.BackColor = Color.White;
                this.erreurEtagere.BackColor = Color.White;
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.erreurCode.Visible = false;
            this.erreurEtagere.Visible = false;

            bool erreurInput = false;

            string code = metroComboBoxCode.Text;
            if(code == "")
            {
                this.erreurCode.Visible = true;
                erreurInput = true;
            }

            string etagere = metroComboBoxEtagere.Text;
            if (etagere == "")
            {
                this.erreurEtagere.Visible = true;
                erreurInput = true;
            }

            if (!erreurInput)
            {
                int id_etagere = 0;
                Livre livre = null;

                // Chercher le livre dans la listes des livres Acceuil
                livre = Acceuil.rechercherLivre(code);

                // Chercher l'etagere dans la listes d'etageres Acceuil
                Etagere eta = Acceuil.RechercherEtagere(etagere);
                eta.livres.Add(livre);

                try
                {
                    Gestionnaire.con.Open();
                    SqlDataReader sdr;

                    // select livre avec code
                    sdr = Livre.Select(0, code);
                    if (sdr.HasRows)
                    {
                        throw new Exception("Un livre possédant le même code existe déjà");
                    }

                    sdr.Close();

                    // Select etagere avec numero etagere
                    sdr = Etagere.Select(0, etagere);
                    if (sdr.Read())
                    {
                        id_etagere = Convert.ToInt32(sdr["id"]);
                    }
                    sdr.Close();

                    // Insert livre
                    Livre.insert(livre, id_etagere);

                    Acceuil.livres.Remove(livre);

                    MetroFramework.MetroMessageBox.Show(this, "Le livre a été remis dans l'étagère en succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch(Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Gestionnaire.con.Close();
                }
                this.Hide();
                this.RemettreLivre_load();
                this.Show();
            }
        }
    }
}
