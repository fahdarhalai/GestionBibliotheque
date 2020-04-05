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
    public partial class RemplacerLivre : UserControl
    {
        public RemplacerLivre()
        {
            InitializeComponent();
        }

        public void RemplacerLivre_Load()
        {
            this.metroComboBoxEtagereRetire.Items.Clear();
            this.metroComboBoxEtagereRemplacant.Items.Clear();
            this.metroComboBoxLivreRetire.Items.Clear();
            this.metroComboBoxLivreRemplacant.Items.Clear();

            this.metroComboBoxEtagereRemplacant.Enabled = false;
            this.metroComboBoxLivreRetire.Enabled = false;
            this.metroComboBoxLivreRemplacant.Enabled = false;

            try
            {
                Gestionnaire.con.Open();
                SqlDataReader sdr;

                // select etageres
                sdr = Etagere.Select();
                while (sdr.Read())
                {
                    metroComboBoxEtagereRetire.Items.Add(sdr["numero"]);
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
                this.groupBox1.BackColor = Color.FromArgb(17, 17, 17);
                this.groupBox2.BackColor = Color.FromArgb(17, 17, 17);
                this.groupBox1.ForeColor = Color.FromArgb(170, 170, 170);
                this.groupBox2.ForeColor = Color.FromArgb(170, 170, 170);
                this.erreurEtagereRemplacant.BackColor = Color.FromArgb(17, 17, 17);
                this.erreurEtagereRetire.BackColor = Color.FromArgb(17, 17, 17);
                this.erreurLivreRemplacant.BackColor = Color.FromArgb(17, 17, 17);
                this.erreurLivreRetire.BackColor = Color.FromArgb(17, 17, 17);
            }
            else
            {
                this.groupBox1.BackColor = Color.White;
                this.groupBox2.BackColor = Color.White;
                this.groupBox1.ForeColor = Color.Black;
                this.groupBox2.ForeColor = Color.Black;
                this.erreurEtagereRemplacant.BackColor = Color.White;
                this.erreurEtagereRetire.BackColor = Color.White;
                this.erreurLivreRemplacant.BackColor = Color.White;
                this.erreurLivreRetire.BackColor = Color.White;
            }
        }

        private void buttonRemplacer_Click(object sender, EventArgs e)
        {
            this.erreurEtagereRetire.Visible = false;
            this.erreurEtagereRemplacant.Visible = false;
            this.erreurLivreRemplacant.Visible = false;
            this.erreurLivreRetire.Visible = false;

            bool erreurInput = false;

            string numEtagere1 = this.metroComboBoxEtagereRetire.Text;
            if(numEtagere1 == "")
            {
                this.erreurEtagereRetire.Visible = true;
                erreurInput = true;
            }

            string numEtagere2 = this.metroComboBoxEtagereRemplacant.Text;
            if(numEtagere2 == "")
            {
                this.erreurEtagereRemplacant.Visible = true;
                erreurInput = true;
            }

            string code1 = this.metroComboBoxLivreRetire.Text;
            if(code1 == "")
            {
                this.erreurLivreRetire.Visible = true;
                erreurInput = true;
            }

            string code2 = this.metroComboBoxLivreRemplacant.Text;
            if(code2 == "")
            {
                this.erreurLivreRemplacant.Visible = true;
                erreurInput = true;
            }

            if (!erreurInput)
            {
                Livre livre = null;
                int id_livre = 0;
                int id_etagere1 = 0;
                int id_etagere2 = 0;

                try
                {
                    Gestionnaire.con.Open();
                    SqlDataReader sdr;

                    // select livre avec code1
                    sdr = Livre.Select(0, code1);
                    if (sdr.Read())
                    {
                        id_livre = Convert.ToInt32(sdr["id"]);
                        id_etagere1 = Convert.ToInt32(sdr["id_etagere"]);
                        livre = new Livre(sdr["code"].ToString(), sdr["titre"].ToString(), Convert.ToDouble(sdr["prix"]));
                    }
                    sdr.Close();

                    // delete livre avec id_livre
                    Livre.Delete(id_livre);
                    Acceuil.livres.Add(livre);

                    // select livre avec code2
                    sdr = Livre.Select(0, code2);
                    if (sdr.Read())
                    {
                        id_livre = Convert.ToInt32(sdr["id"]);
                        id_etagere2 = Convert.ToInt32(sdr["id"]);
                        livre = new Livre(sdr["code"].ToString(), sdr["titre"].ToString(), Convert.ToDouble(sdr["prix"]));
                    }
                    sdr.Close();

                    // update livre avec id_livre
                    Livre.Update(id_livre, id_etagere1);

                    MetroFramework.MetroMessageBox.Show(this, "Le livre a été remplacé en succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                this.RemplacerLivre_Load();
                this.Show();
            }
        }

        private void metroComboBoxEtagereRetire_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.metroComboBoxLivreRetire.Items.Clear();
            this.metroComboBoxEtagereRemplacant.Items.Clear();

            if (this.metroComboBoxLivreRemplacant.Enabled)
            {
                this.metroComboBoxLivreRemplacant.Items.Clear();
            }

            this.metroComboBoxLivreRetire.Enabled = true;
            this.metroComboBoxEtagereRemplacant.Enabled = true;

            string numEtagere = this.metroComboBoxEtagereRetire.Text;
            int id_etagere = 0;

            try
            {
                Gestionnaire.con.Open();
                SqlDataReader sdr;

                // select etageres
                sdr = Etagere.Select();
                while (sdr.Read())
                {
                    if (numEtagere == sdr["numero"].ToString())
                    {
                        id_etagere = Convert.ToInt32(sdr["id"]);
                        continue;
                    }
                    this.metroComboBoxEtagereRemplacant.Items.Add(sdr["numero"].ToString());
                }
                sdr.Close();

                this.metroComboBoxLivreRetire.Items.Clear();
                // select livre avec id_etagere
                sdr = Livre.Select(0, "", id_etagere);
                while (sdr.Read())
                {
                    metroComboBoxLivreRetire.Items.Add(sdr["code"]);
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

        private void metroComboBoxEtagereRemplacant_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.metroComboBoxLivreRemplacant.Items.Clear();

            this.metroComboBoxLivreRemplacant.Enabled = true;
            string numEtagere = this.metroComboBoxEtagereRemplacant.Text;
            int id_etagere = 0;

            try
            {
                Gestionnaire.con.Open();
                SqlDataReader sdr;

                // select etagere avec numEtagere
                sdr = Etagere.Select(0, numEtagere);
                if (sdr.Read())
                {
                    id_etagere = Convert.ToInt32(sdr["id"]);
                }
                sdr.Close();

                this.metroComboBoxLivreRemplacant.Items.Clear();
                // select livre avec id_etagere
                sdr = Livre.Select(0, "", id_etagere);
                while (sdr.Read())
                {
                    metroComboBoxLivreRemplacant.Items.Add(sdr["code"]);
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
    }
}
