using MySql.Data.MySqlClient;


namespace UrInfo
{
    public class CommandeManager
    {
        public List<Commande> SelectAllCommande()
        {
            //on ouvre une connexion grace à la classe static () 
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();
            // On ecris la requête
            commandeBDD.CommandText = "SELECT * FROM Commande ;";
            List<Commande> listeCommandes = new List<Commande>();
            MySqlDataReader lecteur = commandeBDD.ExecuteReader();
            
             while (lecteur.Read())
                {
                Commande uneCommande = new Commande(int.Parse(lecteur[0].ToString()), lecteur[1].ToString(), int.Parse(lecteur[2].ToString()), lecteur[3].ToString(), lecteur[4].ToString(), int.Parse(lecteur[5].ToString()));
                   listeCommandes.Add(uneCommande);
             
            }

            BddConnexion.FermerConnexion(connexion);
            return listeCommandes;
        }
        public bool updateEtat(int numero, int valeur)
        {
            bool success;
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();

            commandeBDD.CommandText = "UPDATE Commande SET etat = @valeur WHERE numero = @numero";
            commandeBDD.Parameters.AddWithValue("@valeur", valeur);
            commandeBDD.Parameters.AddWithValue("@numero", numero);
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


        // Mette à jour la date d'expédition
        public bool updateDateExpedition(int numero)
        {
            string newDate = DateTime.Now.ToString("yyyy-MM-dd");
            //string newDate = null;
            bool success;
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();

            commandeBDD.CommandText = "UPDATE Commande SET dateExpedition = @date WHERE numero = @numero";
            
            commandeBDD.Parameters.AddWithValue("@date", newDate);
            commandeBDD.Parameters.AddWithValue("@numero", numero);
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

        public Commande GetCommande(int numero)
        {
            Commande uneCommande = new Commande(0,null,0,null,null,0);


            bool success;
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();

            commandeBDD.CommandText = "SELECT * FROM Commande WHERE numero = @numero";
            commandeBDD.Parameters.AddWithValue("@numero", numero);
                MySqlDataReader lecteur = commandeBDD.ExecuteReader();

                while (lecteur.Read())
                {
                    uneCommande = new Commande(int.Parse(lecteur[0].ToString()), lecteur[1].ToString(), int.Parse(lecteur[2].ToString()), lecteur[3].ToString(), lecteur[4].ToString(), int.Parse(lecteur[5].ToString()));
                    success = true;
                }
                
            

            BddConnexion.FermerConnexion(connexion);
            return uneCommande;
        }


        // Récupérer les commandes en état 1 et 2 pour les Comptables :
        public List<Commande> SelectAllCommande1et2()
        {
            //on ouvre une connexion grace à la classe static () 
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();
            // On ecris la requête
            commandeBDD.CommandText = "SELECT * FROM Commande WHERE etat = 1 OR etat = 2 ORDER BY dateCommande;";
            List<Commande> listeCommandes = new List<Commande>();
            MySqlDataReader lecteur = commandeBDD.ExecuteReader();

            while (lecteur.Read())
            {

                Commande uneCommande = new Commande(int.Parse(lecteur[0].ToString()), lecteur[1].ToString(), int.Parse(lecteur[2].ToString()), lecteur[3].ToString(), lecteur[4].ToString(), int.Parse(lecteur[5].ToString()));
                listeCommandes.Add(uneCommande);

            }

            BddConnexion.FermerConnexion(connexion);
            return listeCommandes;
        }


        // Récupérer les commandes en état 2, 3 et 4 pour les Préparateurs :
        public List<Commande> SelectAllCommande2et3et4()
        {
            //on ouvre une connexion grace à la classe static () 
            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();
            // On ecris la requête
            commandeBDD.CommandText = "SELECT * FROM Commande WHERE etat = 2 OR etat = 3 OR etat = 4 ORDER BY dateCommande;";
            List<Commande> listeCommandes = new List<Commande>();
            MySqlDataReader lecteur = commandeBDD.ExecuteReader();

            while (lecteur.Read())
            {

                Commande uneCommande = new Commande(int.Parse(lecteur[0].ToString()), lecteur[1].ToString(), int.Parse(lecteur[2].ToString()), lecteur[3].ToString(), lecteur[4].ToString(), int.Parse(lecteur[5].ToString()));
                listeCommandes.Add(uneCommande);

            }

            BddConnexion.FermerConnexion(connexion);
            return listeCommandes;
        }

        /// Afficher les produits de la commande sélectionnée :
        public List<Produit> SelectProduits(int numero)
        {
            List<Produit> listeProduits = new List<Produit>();
           

            MySqlConnection connexion = BddConnexion.OuvrirConnexion();
            MySqlCommand commandeBDD = connexion.CreateCommand();
            commandeBDD.CommandText = "SELECT * FROM commande INNER JOIN comporter ON commande.numero = comporter.idCommande INNER JOIN produit ON comporter.idProduit = produit.reference WHERE comporter.idCommande = @numero;";
            commandeBDD.Parameters.AddWithValue("@numero", numero);

            MySqlDataReader lecteur = commandeBDD.ExecuteReader();


            while (lecteur.Read())
            {
                
                Produit unProduit = new Produit(lecteur["nom"].ToString(), float.Parse(lecteur["prix"].ToString()), lecteur["description"].ToString(), float.Parse(lecteur["poids"].ToString()), lecteur["dimension"].ToString(), int.Parse(lecteur["qte"].ToString()));
                listeProduits.Add(unProduit);
            }

            BddConnexion.FermerConnexion(connexion);
            return listeProduits;
        }
    }
}
