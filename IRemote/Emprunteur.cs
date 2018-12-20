using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public class Emprunteur
    {
        String id_emprunteur,nom,prenom;
        Compte compte;

        public Emprunteur(string id_emprunteur, string nom, string prenom,Compte compte)
        {
            this.id_emprunteur = id_emprunteur;
            this.nom = nom;
            this.prenom = prenom;
            this.compte = compte;
        }
        public void setId_emprunteur(String id_emprunteur)
        {
            this.id_emprunteur = id_emprunteur;
        }
        public string getId_emprunteur()
        {
            return id_emprunteur;
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
