using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public class Enseignant : Emprunteur
    {
         
        String grade;
        

        public Enseignant(String grade, string matricule, string nom, string prenom, Compte compte):base(matricule, nom, prenom, compte)
        {
            
            this.grade = grade;
        }
        
       
        public void setGrade(String grade)
        {
            this.grade = grade;
        }
        public String getGrade()
        {
            return grade;
        }
        
    }
}
