using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GestionLivres
{
    public partial class Lister : UserControl
    {
        public Lister()
        {
            InitializeComponent();
            this.dataGridView.AutoGenerateColumns = false;
        }

        public void Lister_load()
        {
            metroComboBoxEtagere.Items.Clear();
            metroComboBoxEtagere.Items.Add("Tout");
            metroComboBoxEtagere.SelectedIndex = 0;

            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();

            try
            {
                Gestionnaire.con.Open();
                SqlDataReader sdr;

                // Select etageres
                sdr = Etagere.Select();
                while (sdr.Read())
                {
                    metroComboBoxEtagere.Items.Add(sdr["numero"]);
                }
                sdr.Close();

                // Select livres
                SqlCommand cmd = Gestionnaire.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Livre.id, code, titre, prix, Etagere.numero from Livre, Etagere where Livre.id_etagere = Etagere.id";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataAdp = new SqlDataAdapter(cmd.CommandText, Gestionnaire.con);
                dataAdp.Fill(dta);
                dataGridView.DataSource = dta;
            }
            catch (Exception ex)
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
                this.dataGridView.BackgroundColor = Color.FromArgb(17, 17, 17);
                this.dataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
                this.dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(170, 170, 170);
            }
            else
            {
                this.dataGridView.BackgroundColor = Color.White;
                this.dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
                this.dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void buttonLister_Click(object sender, EventArgs e)
        {
            string etagere = metroComboBoxEtagere.Text;

            try
            {
                Gestionnaire.con.Open();
                SqlCommand cmd = Gestionnaire.con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                switch (etagere)
                {
                    case "Tout":
                        cmd.CommandText = "select Livre.id, code, titre, prix, Etagere.numero from Livre, Etagere where Livre.id_etagere = Etagere.id";
                        break;
                    default:
                        cmd.CommandText = "select Livre.id, code, titre, prix, Etagere.numero from Livre, Etagere where Livre.id_etagere = Etagere.id and Etagere.numero = '" + etagere + "'";
                        break;
                }

                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataAdp = new SqlDataAdapter(cmd.CommandText, Gestionnaire.con);
                dataAdp.Fill(dta);
                dataGridView.DataSource = dta;
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
