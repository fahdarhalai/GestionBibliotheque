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
    public partial class RetirerLivre : UserControl
    {
        public RetirerLivre()
        {
            InitializeComponent();
        }

        public void RetirerLivre_Load()
        {
            metroComboBoxEtagere.Items.Clear();
            metroComboBoxLivre.Items.Clear();

            try
            {
                Gestionnaire.con.Open();

                // select etageres
                SqlDataReader sdr = Etagere.Select();
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
                this.erreurNumero.BackColor = Color.FromArgb(17, 17, 17);
            }
            else
            {
                this.erreurCode.BackColor = Color.White;
                this.erreurNumero.BackColor = Color.White;
            }
        }

        void metroComboBoxLivre_Load(string numEtagere)
        {
            this.metroComboBoxLivre.Items.Clear();

            try
            {
                Gestionnaire.con.Open();
                SqlDataReader sdr;

                // Select etagere avec numEtagere
                sdr = Etagere.Select(0, numEtagere);
                int id_etagere = 0;
                if (sdr.Read())
                {
                    id_etagere = Convert.ToInt32(sdr["id"]);
                }
                sdr.Close();

                // Select livres avec id_etagere
                sdr = Livre.Select(0, "", id_etagere);
                while (sdr.Read())
                {
                    this.metroComboBoxLivre.Items.Add(sdr["code"].ToString());
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

        private void metroComboBoxEtagere_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.metroComboBoxLivre.Height = 10;
            bool erreur = false;

            string numEtagere = this.metroComboBoxEtagere.Text;
               
            if(numEtagere == "")
            {
                erreur = true;
            }

            if (!erreur)
            {
                metroComboBoxLivre_Load(numEtagere);
            }
        }

        private void buttonRetirer_Click(object sender, EventArgs e)
        {
            this.erreurNumero.Visible = false;
            this.erreurCode.Visible = false;

            bool erreurInput = false;

            string numEtagere = this.metroComboBoxEtagere.Text;
            if (numEtagere == "")
            {
                this.erreurNumero.Visible = true;
                erreurInput = true;
            }

            string codeLivre = this.metroComboBoxLivre.Text;
            if (codeLivre == "")
            {
                this.erreurCode.Visible = true;
                erreurInput = true;
            }

            if (!erreurInput)
            {
                Livre livre = null;
                int id_livre = 0;

                try
                {
                    Gestionnaire.con.Open();
                    SqlDataReader sdr;

                    // select livre avec codeLivre
                    sdr = Livre.Select(0, codeLivre);

                    if (sdr.Read())
                    {
                        id_livre = Convert.ToInt32(sdr["id"]);
                        livre = new Livre(sdr["code"].ToString(), sdr["titre"].ToString(), Convert.ToDouble(sdr["prix"]));
                    }

                    sdr.Close();

                    // Insert livre avec id_etagere
                    Livre.Delete(id_livre);

                    MetroFramework.MetroMessageBox.Show(this, "Le livre a été retiré en succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }catch(Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                finally
                {
                    Gestionnaire.con.Close();
                }
                this.Hide();
                this.RetirerLivre_Load();
                this.Show();
            }
        }
    }
}
