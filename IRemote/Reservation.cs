using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public class Reservation
    {
        Emprunteur emprunteur;
        Ouvrage ouvrage;
        string date_reservation;

        public Reservation(Emprunteur emprunteur, Ouvrage ouvrage)
        {
            this.emprunteur = emprunteur;
            this.ouvrage = ouvrage;
            DateTime dt = DateTime.Now;
            date_reservation = date_reservation = dt.ToString("yyyy-MM-dd HH:mm:ss");
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
        public String getDate_reservation()
        {
            return date_reservation;
        }
        public void setDate_reservation(String date_reservation)
        {
            this.date_reservation = date_reservation;
        }
    }
}
