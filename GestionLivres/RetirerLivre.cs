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

            Gestionnaire.con.Open();
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from Etagere";
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                metroComboBoxEtagere.Items.Add(sdr["numero"]);
            }

            sdr.Close();

            Gestionnaire.con.Close();
        }

        void metroComboBoxLivre_Load(string numEtagere)
        {
            this.metroComboBoxLivre.Items.Clear();
            Gestionnaire.con.Open();
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = $"select id from Etagere where numero='{numEtagere}'";
            SqlDataReader sdr = cmd.ExecuteReader();

            int id_etagere = 0;
            if (sdr.Read())
            {
                id_etagere = Convert.ToInt32(sdr["id"]);
            }

            sdr.Close();

            cmd.CommandText = $"select * from Livre where id_etagere={id_etagere}";
            sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                this.metroComboBoxLivre.Items.Add(sdr["code"].ToString());
            }

            sdr.Close();
            Gestionnaire.con.Close();
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

                Gestionnaire.con.Open();

                SqlCommand cmd = Gestionnaire.con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // selection du livre de la base de données
                cmd.CommandText = $"select * from Livre where code='{codeLivre}'";
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    id_livre = Convert.ToInt32(sdr["id"]);
                    livre = new Livre(sdr["code"].ToString(), sdr["titre"].ToString(), Convert.ToDouble(sdr["prix"]));
                }

                sdr.Close();

                // Insertion du livre dans la table
                cmd.CommandText = $"delete from Livre where id={id_livre}";
                int res = cmd.ExecuteNonQuery();
                Gestionnaire.con.Close();

                if (res == 1)
                {
                    metroComboBoxLivre_Load(numEtagere);
                    // Acceuil.livres.Add(livre);
                }
            }
        }
    }
}
