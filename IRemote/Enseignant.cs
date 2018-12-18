using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public class Enseignant
    {
        int grade;
        String nom, prenom, matricule;
        Compte compte;

        public Enseignant(int grade, string nom, string prenom, string matricule, Compte compte)
        {
            this.grade = grade;
            this.nom = nom;
            this.prenom = prenom;
            this.matricule = matricule;
            this.compte = compte;
        }

        public void setCompte(Compte compte)
        {
            this.compte = compte;
        }

        public Compte getCompte()
        {
            return compte;
        }
        
        public void setMatricule(String matricule)
        {
            this.matricule = matricule;
        }
        public string getMatricule()
        {
            return matricule;
        }
        public void setGrade(int grade)
        {
            this.grade = grade;
        }
        public int getGrade()
        {
            return grade;
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
