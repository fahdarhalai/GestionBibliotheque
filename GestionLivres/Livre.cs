using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
