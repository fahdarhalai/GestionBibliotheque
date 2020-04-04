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

            foreach(Livre livre in Acceuil.livres)
            {
                metroComboBoxCode.Items.Add(livre.Code);
            }

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
                foreach(Livre li in Acceuil.livres)
                {
                    if(li.Code == code)
                    {
                        livre = li;
                        break;
                    }
                }

                // Chercher l'etagere dans la listes d'etageres Acceuil
                foreach(Etagere eta in Acceuil.etageres)
                {
                    if(eta.Numero == etagere)
                    {
                        eta.livres.Add(livre);
                    }
                }

                Gestionnaire.con.Open();

                SqlCommand cmd = Gestionnaire.con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Selection du id etagere
                cmd.CommandText = $"select id from Etagere where numero='{etagere}'";
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    id_etagere = Convert.ToInt32(sdr["id"]);
                }
                
                sdr.Close();

                // Insertion du livre dans la table
                cmd.CommandText = $"insert into Livre (code,titre,prix,id_etagere) values ('{livre.Code}','{livre.Titre}',TRY_PARSE('{livre.Prix.ToString().Replace(',', '.')}' as float using 'en-US'),{id_etagere})";
                cmd.ExecuteNonQuery();

                Acceuil.livres.Remove(livre);
                Gestionnaire.con.Close();
            }
        }
    }
}
