using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRemote;

namespace Serveur
{
    class ImplBibliothecaire : MarshalByRefObject, IBibliothecaire , IEmprunteur
    {
        ArrayList reservations = new ArrayList();
        ArrayList ouvrages = new ArrayList();
        public bool ajouter_ouvrage(Ouvrage ouvrage)
        {
            for(int i = 0;i<ouvrages.Count;i++)
            {
                if(((Ouvrage)ouvrages[i]).getId_ouvrage()== ouvrage.getId_ouvrage())
                {
                    return false;
                }
            }
            ouvrages.Add(ouvrage);
            return true;
                
        }

        public Ouvrage modifier_ouvrage(int id_ouvrage)
        {
            for (int i = 0; i < ouvrages.Count; i++)
            {
                if (((Ouvrage)ouvrages[i]).getId_ouvrage() == id_ouvrage)
                {
                    return (Ouvrage) ouvrages[i];
                }
            }
            return null;
        }

        public bool supprimer_ouvrage(int id_ouvrage)
        {
            for (int i = 0; i < ouvrages.Count; i++)
            {
                if (((Ouvrage)ouvrages[i]).getId_ouvrage() == id_ouvrage)
                {
                    ouvrages.Remove(ouvrages[i]);
                    return true;
                }
            }
            return false;
        }

        public ArrayList consulte()
        {
            return ouvrages;
        }

        public ArrayList recherche_titre(string titre)
        {
            ArrayList res = new ArrayList();
            for(int i = 0; i < ouvrages.Count; i++)
            {
                if (((Ouvrage)ouvrages[i]).getTitre() == titre)
                {
                    res.Add(ouvrages[i]);
                }
            }
            return res;
        }

        public ArrayList recherche_auteur(string auteur)
        {
            ArrayList res = new ArrayList();
            for(int i = 0; i < ouvrages.Count; i++)
            {
                for(int j = 0; j < ((Ouvrage)ouvrages[i]).getAuteurs().Length; j++)
                {
                    if(((Ouvrage)ouvrages[i]).getAuteurs()[j] == auteur)
                    {
                        res.Add(ouvrages[i]);
                    }
                }
            }
            return res;
        }

        public ArrayList recherche_mot_cle(string mot_cle)
        {
            ArrayList res = new ArrayList();
            for (int i = 0; i < ouvrages.Count; i++)
            {
                for (int j = 0; j < ((Ouvrage)ouvrages[i]).getMots_cle().Length; j++)
                {
                    if (((Ouvrage)ouvrages[i]).getMots_cle()[j] == mot_cle)
                    {
                        res.Add(ouvrages[i]);
                    }
                }
            }
            return res;
        }

        public ArrayList recherche_theme(string theme)
        {
            ArrayList res = new ArrayList();
            for (int i = 0; i < ouvrages.Count; i++)
            {
                if (((Ouvrage)ouvrages[i]).getTheme() == theme)
                {
                    res.Add(ouvrages[i]);
                }
            }
            return res;
        }

        /*public bool reservation(int id_emprunteur, int ouvrage)
        {
               
        }*/
    }
}
