using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace UrInfo
{
    internal class UtilisateurManager
    {

        public Utilisateur FindUtilisateur(int id)
        {

            //on ouvre une connexion grace à la classe static () 
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();
            // On ecris la requête
            commandeBDD.CommandText = "SELECT * FROM Utilisateur WHERE id= @id;";
            commandeBDD.Parameters.AddWithValue("@id", id);

            Utilisateur utilisateur = new Utilisateur(0, null, null, null, null, null);
            MySqlDataReader lecteur = commandeBDD.ExecuteReader();

            while (lecteur.Read())
            {// Accéder avec le nom de la colonne.

                //utilisateur = new Utilisateur(int.Parse(lecteur[0].ToString()), lecteur[1].ToString(), lecteur[2].ToString(), lecteur[3].ToString());
                utilisateur.Id = int.Parse(lecteur[0].ToString());
                utilisateur.Login = lecteur[1].ToString();
                utilisateur.Mdp = lecteur[2].ToString();
                utilisateur.Email = lecteur[3].ToString();
                utilisateur.Adresse = lecteur[4].ToString();
                utilisateur.Telephone = lecteur[5].ToString();

            }
            return utilisateur;
        }
    }
}
