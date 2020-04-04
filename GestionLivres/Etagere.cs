using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
