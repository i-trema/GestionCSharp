using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    public class Produit
    {
        string nom;
        float prix;
        string description;
        float poids;
        string dimension;
        int qte;

        public Produit(string nom, float prix, string description, float poids, string dimension, int qte)
        {
            this.nom = nom;
            this.prix = prix;
            this.description = description;
            this.poids = poids;
            this.dimension = dimension;
            this.qte = qte;
        }

        public string Nom { get => nom; set => nom = value; }
        public float Prix { get => prix; set => prix = value; }
        public string Description { get => description; set => description = value; }
        public float Poids { get => poids; set => poids = value; }
        public string Dimension { get => dimension; set => dimension = value; }

        public int Qte { get => qte; set => qte = value; }
    }

}
