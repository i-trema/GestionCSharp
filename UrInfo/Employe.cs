using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrInfo
{
    public class Employe
    {
        private int id;
        private string login;
        private string mdp;
        private string type;

        public Employe(int id, string login, string mdp, string type)
        {
            this.id = id;
            this.login = login;
            this.mdp = mdp;
            this.type = type;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Type { get => type; set => type = value; }
    }
}
