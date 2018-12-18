using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using IRemote;

namespace Bibliothecaire
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpChannel cnl = new TcpChannel();
                ChannelServices.RegisterChannel(cnl, false);
                IBibliothecaire obj = (IBibliothecaire)Activator.GetObject(typeof(IBibliothecaire), "tcp://localhost:1234/obj");
                String[] m = { "salam" , "bonjour"};
                String[] a = { "rania", "oussama" , "mohamed amine" };
                Ouvrage o = new Ouvrage(m, a, "revision", "poc", "memoire", 1);

                Boolean b = obj.ajouter_ouvrage(o);
                Console.WriteLine(b);
                Console.ReadLine();
            }catch(Exception e)
            {
                Console.WriteLine("erreur : " + e);
                Console.ReadLine();
            }
        }
    }
}
