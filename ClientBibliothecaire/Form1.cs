using IRemote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBibliothecaire
{
    public partial class AjouterOuvrage : Form
    {
        public AjouterOuvrage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TcpChannel cnl = new TcpChannel();
                ChannelServices.RegisterChannel(cnl, false);
                IBibliothecaire obj = (IBibliothecaire)Activator.GetObject(typeof(IBibliothecaire), "tcp://localhost:1234/obj");
                String b;
                if (memoire.Checked)
                {
                    b = "memoire";
                }
                else
                {
                    if (livre.Checked)
                    {
                        b = "livre";
                    }
                    else
                    {
                        b = "these";
                    }
                }
                Ouvrage o = new Ouvrage(mots.Text,auteurs.Text,title.Text,theme.Text,b, code.Text);

                Boolean br = obj.ajouter_ouvrage(o);
                Console.WriteLine(br);
                Console.ReadLine();
            }
            catch (Exception m)
            {
                Console.WriteLine("erreur : " + m);
                Console.ReadLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
