using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public class Bibliothecaire
    {
        Compte compte;
        String nom, prenom;

        public Bibliothecaire(Compte compte, string nom, string prenom)
        {
            this.compte = compte;
            this.nom = nom;
            this.prenom = prenom;
        }
        public void setCompte(Compte compte)
        {
            this.compte = compte;
        }

        public Compte getCompte()
        {
            return compte;
        }
        public void setNom(String nom)
        {
            this.nom = nom;
        }
        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }
        public String getNom()
        {
            return nom;
        }
        public String getPrenom()
        {
            return prenom;
        }
    }
}
