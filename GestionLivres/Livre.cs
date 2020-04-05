using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestionLivres
{
    public class Livre
    {
        private string code;
        private string titre;
        private double prix;

        public Livre(string code, string titre, double prix)
        {
            this.code = code;
            this.titre = titre;
            this.prix = prix;
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Titre
        {
            get
            {
                return titre;
            }
            set
            {
                titre = value;
            }
        }

        public double Prix
        {
            get
            {
                return prix;
            }
            set
            {
                prix = value;
            }
        }


        public static SqlDataReader Select(int id = 0, string code = "", int id_etagere = 0)
        {
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string command = "select * from Livre";

            if(id != 0)
            {
                command += $" where id={id}";
                if (code != "")
                {
                    command += $" and code='{code}'";
                    if (id_etagere != 0)
                    {
                        command += $" and id_etagere={id_etagere}";
                    }
                }
                else if (id_etagere != 0)
                {
                    command += $" and id_etagere={id_etagere}";
                }
            }else if (code != "")
            {
                command += $" where code='{code}'";
                if (id_etagere != 0)
                {
                    command += $" and id_etagere={id_etagere}";
                }
            }
            else if (id_etagere != 0)
            {
                command += $" where id_etagere={id_etagere}";
            }


            cmd.CommandText = command;
            SqlDataReader sdr = cmd.ExecuteReader();

            return sdr;
        }

        public static int Delete(int id = 0, string code = "", int id_etagere = 0)
        {
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string command = "delete from Livre where";

            if (id != 0)
            {
                command += $" id = {id}";
            }
            else if (code != "")
            {
                command += $" where code='{code}'";
                if (id_etagere != 0)
                {
                    command += $" and id_etagere={id_etagere}";
                }
            }
            else if (id_etagere != 0)
            {
                command += $" where id_etagere={id_etagere}";
            }

            cmd.CommandText = command;
            int res = cmd.ExecuteNonQuery();

            return res;
        }

        public static int Update(int id, int id_etagere)
        {
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string command = $"update Livre set id_etagere={id_etagere} where id={id}";

            cmd.CommandText = command;
            int res = cmd.ExecuteNonQuery();

            return res;
        }

        public static int insert(Livre livre, int id_etagere)
        {
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string command = $"insert into Livre (code,titre,prix,id_etagere) values ('{livre.Code}','{livre.Titre}',TRY_PARSE('{livre.Prix.ToString().Replace(',', '.')}' as float using 'en-US'),{id_etagere})";

            cmd.CommandText = command;
            int res = cmd.ExecuteNonQuery();

            return res;
        }
    }
}
