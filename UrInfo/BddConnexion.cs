using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    public static class BddConnexion
    {
        private static string infosConnex = "server=localhost;port=3306;database=projetcsharp;User Id=ianis;password=test;Allow User Variables=True";
        
        public static MySqlConnection OuvrirConnexion(){
            MySqlConnection connexion;
            connexion = new MySqlConnection(infosConnex);
            try
            {
                
                connexion.Open();
                Console.WriteLine("connexion bdd OK");
            }
            catch (Exception)
            {
                
            }
            return connexion;
        }
        public static void FermerConnexion(MySqlConnection connexion)
        {
            try
            {
                connexion.Close();
            }
            catch (Exception)
            {
                
            }
            
        }
    }
}
