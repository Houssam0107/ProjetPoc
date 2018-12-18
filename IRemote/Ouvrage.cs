using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    [Serializable]
    public class Ouvrage
    {
        String[] mots_cle ,auteurs ;
        String titre,theme,type;
        int id_ouvrage;

        public Ouvrage(string[] mots_cle, string[] auteurs, string titre, string theme,string type, int id_ouvrage)
        {
            this.mots_cle = mots_cle;
            this.auteurs = auteurs;
            this.titre = titre;
            this.theme = theme;
            this.type = type;
            this.id_ouvrage = id_ouvrage;
        }
        public int getId_ouvrage()
        {
            return id_ouvrage;
        }
        public void setId_ouvrage(int id_ouvrage)
        {
            this.id_ouvrage = id_ouvrage;
        }
        public string getType()
        {
            return type;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public void setMots_cle(String [] mots_cle)
        {
            this.mots_cle = mots_cle;
        }
        public void setAuteurs(string[] auteurs)
        {
            this.auteurs = auteurs;
        }
        public void setTitre(string titre)
        {
            this.titre = titre;
        }
        public void setTheme(string theme)
        {
            this.theme = theme;
        }
        public String [] getMots_cle()
        {
            return mots_cle;
        }
        public string[] getAuteurs()
        {
            return auteurs;

        }
        public string getTitre()
        {
            return titre
;
        }
        public string getTheme()
        {
            return theme;
        }

    }
}
