using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestionLivres
{
    public class Etagere
    {
        private string numero;
        public List<Livre> livres;

        public Etagere(string numero)
        {
            this.numero = numero;
            this.livres = new List<Livre>();
        }

        public Etagere(string numero, List<Livre> livres) : this(numero)
        {
            this.livres = livres.ToList();
        }

        public string Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public static SqlDataReader Select(int id = 0, string numero = "")
        {
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string command = "select * from Etagere";

            if(id != 0)
            {
                command += $" where id={id}";
                if(numero != "")
                {
                    command += $" and numero='{numero}'";
                }
            }else if(numero != "")
            {
                command += $" where numero='{numero}'";
            }


            cmd.CommandText = command;
            SqlDataReader sdr = cmd.ExecuteReader();

            return sdr;
        }

        public static int Insert(string numEtagere)
        {
            SqlCommand cmd = Gestionnaire.con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            // Insertion du livre dans la table
            cmd.CommandText = $"insert into Etagere (numero) values ('{numEtagere}')";
            int res = cmd.ExecuteNonQuery();

            return res;
        }
    }
}
