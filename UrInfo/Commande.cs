using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    public class Commande
    {
        private int numero;
        private string dateCommande;
        private int etat;
        private string dateExpedition;
        private string commentaire;
        private int idUtilisateur;

        public Commande(int numero, string dateCommande, int etat, string dateExpedition, string commentaire, int idUtilisateur)
        {
            this.numero = numero;
            this.dateCommande = dateCommande;
            this.etat = etat;
            this.dateExpedition = dateExpedition;
            this.commentaire = commentaire;
            this.idUtilisateur = idUtilisateur;
        }

        public string EtatToString()
        {
            //if (this.etat == 1)
            //{
            //    return "En attente de paiement";

            //}
            //else
            //{
            //    return "Validé";
            //}
            switch (this.etat)
            {
                case 1:
                    return "En attente de paiement";
                    break;
                case 2:
                    return "Validé";
                    break;
                case 3:
                    return "En cours de préparation";
                    break;
                case 4:
                    return "Expédié";
                    break;

                default: 
                    return "";

            }
        }


        public int Numero { get => numero; set => numero = value; }
        public string DateCommande { get => dateCommande; set => dateCommande = value; }
        public int Etat { get => etat; set => etat = value; }
        public string DateExpedition { get => dateExpedition; set => dateExpedition = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public int IdUtilisateur { get => idUtilisateur; set => idUtilisateur = value; }
    }




}
