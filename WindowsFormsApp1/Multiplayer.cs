using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    public partial class Multiplayer : Form
    {
        public Multiplayer()
        {
            InitializeComponent();
        }

        private void buttonListener_Click(object sender, EventArgs e)
        {
           
            
            PlayOnline playOnline = new PlayOnline(9,9);
            playOnline.SocketListener();
            this.Hide();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            labelIP.Visible = true;
            labelPort.Visible = true;
            buttonConfirm.Visible = true;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            
            PlayOnline playOnline = new PlayOnline(9, 9);
            playOnline.ipAdress = IPAddress.Parse(textBox1.Text);
            playOnline.port = int.Parse(textBox2.Text);
            playOnline.SocketClint();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            mainGame mainGame = new mainGame();
            mainGame.Show();
            this.Hide();
        }
    }
}
