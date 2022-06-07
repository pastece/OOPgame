using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mainGame : Form
    {

        public static string un;
       

        public mainGame()
        {
            InitializeComponent();
            
        }

       

        private void settingb_Click(object sender, EventArgs e)
        {
            Settings skip = new Settings();
            skip.Show();
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            mainGame kapat = new mainGame();
            Application.ExitThread();
        }

        private void mainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Do you want to close the program ? ", "Close", MessageBoxButtons.YesNo);

            if (secim == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (secim == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void logoutb_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            un = "";
            this.Hide();
            form1.Show();
        }

        private void mainGame_Load(object sender, EventArgs e)
        {
            if (un == "admin")
            {
                buttonUserControl.Visible = true;
            }
            else
                buttonUserControl.Visible = false;


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            managerScreen skip = new managerScreen();
            skip.Show();
        }

        

       
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            int r = settings.row;
            int c = settings.column;
            PlayGame game = new PlayGame(r, c);
            this.Hide();
        }

        private void HelpScreenBtn_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            help.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            profileScreen profileScreen = new profileScreen();
            profileScreen.Show();
        }

        private void buttonUserControl_Click(object sender, EventArgs e)
        {
            managerScreen ms = new managerScreen();
            ms.Show();
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            scores.Show();
        }

        private void buttonMultiplayer_Click(object sender, EventArgs e)
        {
            Multiplayer multiplayer = new Multiplayer();
            multiplayer.Show();
            this.Hide();
        }
    }
}
