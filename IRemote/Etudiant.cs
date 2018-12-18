using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public class Etudiant
    {
        int numero_carte;
        String nom, prenom,specialite,niveau;
        Compte compte;
        public Etudiant(int numero_carte, string nom, string prenom, string specialite, string niveau, Compte compte)
        {
            this.numero_carte = numero_carte;
            this.nom = nom;
            this.prenom = prenom;
            this.specialite = specialite;
            this.niveau = niveau;
            this.compte = compte;
        }
        public void setNumero_carte(int numero_carte)
        {
            this.numero_carte = numero_carte;
        }
        public void setNom(String nom)
        {
            this.nom = nom;
        }
        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }
        public void setSpecialite(String specialite)
        {
            this.specialite = specialite;
        }
        public String getSpecialite()
        {
            return specialite;
        }
        public void setNiveau(String niveau)
        {
            this.niveau = niveau;
        }
        public String getNiveau()
        {
            return niveau;
        }
        public int getNumero_carte()
        {
            return numero_carte;
        }
        public String getNom()
        {
            return nom;
        }
        public String getPrenom()
        {
            return prenom;
        }
        public void setCompte(Compte compte)
        {
            this.compte = compte;
        }
        public Compte getCompte()
        {
            return compte;
        }
    }
}
