using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    [Serializable]
    public class Compte
    {
        string usename, mot_de_passe;

        public Compte(string usename, string mot_de_passe)
        {
            this.usename = usename;
            this.mot_de_passe = mot_de_passe;
        }
        public void setUsername(string username)
        {
            this.usename = usename;
        }
        public void setMot_de_passe(string mot_de_passe)
        {
            this.mot_de_passe = mot_de_passe;
        }
        public string getUsername()
        {
            return usename;
        }
        public string getMot_de_passe()
        {
            return mot_de_passe;
        }
    }
}
