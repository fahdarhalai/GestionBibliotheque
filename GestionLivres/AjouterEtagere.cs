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
                Gestionnaire.con.Open();

                SqlCommand cmd = Gestionnaire.con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Insertion du livre dans la table
                cmd.CommandText = $"insert into Etagere (numero) values ('{numEtagere}')";
                cmd.ExecuteNonQuery();

                Etagere etagere = new Etagere(numEtagere);
                Acceuil.etageres.Add(etagere);
                Gestionnaire.con.Close();
            }
        }
    }
}
