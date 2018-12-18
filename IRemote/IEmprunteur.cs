using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public interface IEmprunteur
    {
        ArrayList consulte();
        ArrayList recherche_titre(String titre);
        ArrayList recherche_auteur(String auteur);
        ArrayList recherche_mot_cle(String mot_cle);
        ArrayList recherche_theme(String theme);
        //Boolean reservation(int id_emprunteur, int ouvrage);
        

    }
}
