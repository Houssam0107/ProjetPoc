using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public class Etudiant : Emprunteur
    {
       
        String specialite,niveau;
        
        public Etudiant(String numero_carte, string nom, string prenom, string specialite, string niveau, Compte compte) : base(numero_carte, nom, prenom, compte)
        {
            this.specialite = specialite;
            this.niveau = niveau;
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
       
    }
}
