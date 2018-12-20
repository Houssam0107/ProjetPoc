using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemote
{
    public interface IBibliothecaire
    {
        Boolean authentification(Compte compte);
        Boolean ajouter_ouvrage(Ouvrage ouvrage);
        Ouvrage modifier_ouvrage(int id_ouvrage);
        Boolean supprimer_ouvrage(int id_ouvrage);

    }
}
