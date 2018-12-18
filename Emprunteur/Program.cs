using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using IRemote;

namespace Emprunteur
{
    class Program
    {
        static void Main(string[] args)
        {


            TcpChannel cnl = new TcpChannel();
            ChannelServices.RegisterChannel(cnl, false);
            IEmprunteur obj = (IEmprunteur)Activator.GetObject(typeof(IEmprunteur), "tcp://localhost:1234/obj");
            ArrayList r = obj.recherche_titre("revision");
            for(int i = 0; i < r.Count; i++)
            {
                Console.WriteLine(((Ouvrage)r[i]).getType());
            }

            Console.ReadLine();
            
        }
    }
}
