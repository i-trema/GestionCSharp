using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    internal class Utilisateur
    {
        int id;
        string login;
        string mdp;
        string email;
        string adresse;
        string telephone;

        public Utilisateur(int id, string login, string mdp, string email, string adresse, string telephone)
        {
            this.id = id;
            this.login = login;
            this.mdp = mdp;
            this.email = email;
            this.adresse = adresse;
            this.telephone = telephone;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Email { get => email; set => email = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }
    }
}
