using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public class Liste_attente
    {
        Emprunteur emprunteur;
        Ouvrage ouvrage;
        string date;

        public Liste_attente(Emprunteur emprunteur, Ouvrage ouvrage)
        {
            this.emprunteur = emprunteur;
            this.ouvrage = ouvrage;
            DateTime dt = DateTime.Now;
            date = date = dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public Emprunteur getEmprunteur()
        {
            return emprunteur;
        }
        public void setEmprunteur(Emprunteur emprunteur)
        {
            this.emprunteur = emprunteur;
        }
        public Ouvrage getOuvrage()
        {
            return ouvrage;
        }
        public void setOuvrage(Ouvrage ouvrage)
        {
            this.ouvrage = ouvrage;
        }
        public String getDate()
        {
            return date;
        }
        public void setDate(String date)
        {
            this.date = date;
        }
    }
}
