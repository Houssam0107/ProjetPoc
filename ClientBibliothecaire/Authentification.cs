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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passe_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpChannel cnl = new TcpChannel();
            ChannelServices.RegisterChannel(cnl, false);
            IBibliothecaire obj = (IBibliothecaire)Activator.GetObject(typeof(IBibliothecaire), "tcp://localhost:1234/obj");
            
            if (obj.authentification(new Compte(user.Text, passe.Text)))
            {
                this.Hide();
                Acceuil acceuil = new Acceuil();
                acceuil.Show();
            }
            else
            {
                MessageBox.Show("Authorization failed make sure you credentials are correct !");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
