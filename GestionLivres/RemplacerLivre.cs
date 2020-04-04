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

            Gestionnaire.con.Open();
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from Etagere";
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                metroComboBoxEtagereRetire.Items.Add(sdr["numero"]);
            }

            sdr.Close();

            Gestionnaire.con.Close();

        }

        public void modeSombre_load()
        {
            if (Gestionnaire.Sombre)
            {
                this.groupBox1.BackColor = Color.FromArgb(17, 17, 17);
                this.groupBox2.BackColor = Color.FromArgb(17, 17, 17);
                this.groupBox1.ForeColor = Color.FromArgb(170, 170, 170);
                this.groupBox2.ForeColor = Color.FromArgb(170, 170, 170);
            }
            else
            {
                this.groupBox1.BackColor = Color.White;
                this.groupBox2.BackColor = Color.White;
                this.groupBox1.ForeColor = Color.Black;
                this.groupBox2.ForeColor = Color.Black;
            }
        }

        void metroComboBoxLivreRetire_Load(int id_etagere)
        {
            this.metroComboBoxLivreRetire.Items.Clear();
            Gestionnaire.con.Open();
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select code from Livre where id_etagere={id_etagere}";
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                metroComboBoxLivreRetire.Items.Add(sdr["code"]);
            }

            sdr.Close();
            Gestionnaire.con.Close();
        }

        void metroComboBoxLivreRemplacant_Load(int id_etagere)
        {
            this.metroComboBoxLivreRemplacant.Items.Clear();
            Gestionnaire.con.Open();
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select code from Livre where id_etagere={id_etagere}";
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                metroComboBoxLivreRemplacant.Items.Add(sdr["code"]);
            }

            sdr.Close();
            Gestionnaire.con.Close();
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

                Gestionnaire.con.Open();

                SqlCommand cmd = Gestionnaire.con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // selection du livre retiré de la base de données
                cmd.CommandText = $"select * from Livre where code='{code1}'";
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    id_livre = Convert.ToInt32(sdr["id"]);
                    id_etagere1 = Convert.ToInt32(sdr["id_etagere"]);
                    livre = new Livre(sdr["code"].ToString(), sdr["titre"].ToString(), Convert.ToDouble(sdr["prix"]));
                }

                sdr.Close();

                // suppression du livre retiré de la base de données
                cmd.CommandText = $"delete from Livre where id={id_livre}";
                cmd.ExecuteNonQuery();
                Acceuil.livres.Add(livre);

                // selection du livre remplaçant de la base de données
                cmd.CommandText = $"select * from Livre where code='{code2}'";
                sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    id_livre = Convert.ToInt32(sdr["id"]);
                    id_etagere2 = Convert.ToInt32(sdr["id"]);
                    livre = new Livre(sdr["code"].ToString(), sdr["titre"].ToString(), Convert.ToDouble(sdr["prix"]));
                }

                sdr.Close();

                // suppression du livre remplaçant de la base de données
                cmd.CommandText = $"delete from Livre where id={id_livre}";
                cmd.ExecuteNonQuery();

                // insertion du livre remplaçant dans la meme etagere
                cmd.CommandText = $"insert into Livre (code,titre,prix,id_etagere) values ('{livre.Code}','{livre.Titre}',TRY_PARSE('{livre.Prix.ToString().Replace(',', '.')}' as float using 'en-US'),{id_etagere1})";
                cmd.ExecuteNonQuery();

                Gestionnaire.con.Close();

                this.metroComboBoxLivreRetire_Load(id_etagere1);
                this.metroComboBoxLivreRemplacant_Load(id_etagere2);
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

            Gestionnaire.con.Open();
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select id, numero from Etagere";
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                if (numEtagere == sdr["numero"].ToString())
                {
                    id_etagere = Convert.ToInt32(sdr["id"]);
                }
                else
                {
                    this.metroComboBoxEtagereRemplacant.Items.Add(sdr["numero"].ToString());
                }
            }

            sdr.Close();
            Gestionnaire.con.Close();

            this.metroComboBoxLivreRetire_Load(id_etagere);
        }

        private void metroComboBoxEtagereRemplacant_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.metroComboBoxLivreRemplacant.Items.Clear();

            this.metroComboBoxLivreRemplacant.Enabled = true;
            string numEtagere = this.metroComboBoxEtagereRemplacant.Text;
            int id_etagere = 0;

            Gestionnaire.con.Open();
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = $"select id from Etagere where numero='{numEtagere}'";
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                id_etagere = Convert.ToInt32(sdr["id"]);
            }

            sdr.Close();
            Gestionnaire.con.Close();

            this.metroComboBoxLivreRemplacant_Load(id_etagere);
        }
    }
}
