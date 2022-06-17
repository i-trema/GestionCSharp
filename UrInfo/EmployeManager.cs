using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    public class EmployeManager
    {
        public List<Employe> SelectAllEmploye()
        {
            //on ouvre une connexion grace à la classe static () 
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();
            // On ecris la requête
            commandeBDD.CommandText = "SELECT * FROM Employe ;";
            List<Employe> listeEmployes = new List<Employe>();
            MySqlDataReader lecteur = commandeBDD.ExecuteReader();
            /*
             while (lecteur.Read())
                {
                    Console.WriteLine(lecteur[0].ToString()); // Première colonne.
                    Console.WriteLine(lecteur[1].ToString()); // Seconde colonne.
                    Console.WriteLine(lecteur[2].ToString()); // Troisième colonne.
                    // ...
                }
            */
            
            while (lecteur.Read())
            {
                // Accéder avec le nom de la colonne.
                Console.WriteLine(lecteur["id"].ToString());
                Console.WriteLine(lecteur["login"].ToString());
                Console.WriteLine(lecteur["mdp"].ToString());
                Console.WriteLine(lecteur["type"].ToString());
                Employe unEmployer = new Employe(int.Parse(lecteur["id"].ToString()), lecteur["login"].ToString(), lecteur["mdp"].ToString(), lecteur["type"].ToString());
                listeEmployes.Add(unEmployer);
            }
            BddConnexion.FermerConnexion(connexion);
            return listeEmployes;
        }

        public Employe FindEmploye(string login)
        {
            
            //on ouvre une connexion grace à la classe static () 
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();
            // On ecris la requête
            commandeBDD.CommandText = "SELECT * FROM Employe WHERE login= @login;";
            commandeBDD.Parameters.AddWithValue("@login", login);

            Employe employe = new Employe(0, null, null, null);
            MySqlDataReader lecteur = commandeBDD.ExecuteReader();

            while (lecteur.Read())
            {// Accéder avec le nom de la colonne.

                //employe = new Employe(int.Parse(lecteur[0].ToString()), lecteur[1].ToString(), lecteur[2].ToString(), lecteur[3].ToString());
                employe.Id = int.Parse(lecteur[0].ToString());
                employe.Login = lecteur[1].ToString();
                employe.Mdp = lecteur[2].ToString();
                employe.Type = lecteur[3].ToString();

            }
            



            BddConnexion.FermerConnexion(connexion);
            return employe;
        }


        public bool updateType(string id, string valeur)
        {
            bool success;
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();

            commandeBDD.CommandText = "UPDATE Employe SET type = @valeur WHERE id = @id";
            commandeBDD.Parameters.AddWithValue("@valeur", valeur);
            commandeBDD.Parameters.AddWithValue("@id", int.Parse(id));
            commandeBDD.ExecuteNonQuery();
            if (commandeBDD.ExecuteNonQuery() == 1)
            {
                // reusite
                success = true;
            }
            else
            {
                // echec
                success = false;
            }
            BddConnexion.FermerConnexion(connexion);
            return success;
        }
    }
}
