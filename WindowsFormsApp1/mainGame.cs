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

        Form1 f1;

        public mainGame(Form1 form)
        {
            InitializeComponent();
            f1 = form;
        }

       

        private void settingb_Click(object sender, EventArgs e)
        {
            Settings skip = new Settings();
            skip.Show();
        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            mainGame kapat = new mainGame(f1);
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
            this.Hide();
            form1.Show();
        }

        private void mainGame_Load(object sender, EventArgs e)
        {
            if (f1.textBox1.Text == "admin")
                buttonUsers.Visible = true;
            

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            managerScreen skip = new managerScreen();
            skip.Show();
        }

        

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            managerScreen skip = new managerScreen();
            skip.Show();
            
        }
    }
}
