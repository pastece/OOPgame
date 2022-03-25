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
        public mainGame()
        {
            InitializeComponent();
        }

        private void mainGame_Load(object sender, EventArgs e)
        {

        }

        private void settingb_Click(object sender, EventArgs e)
        {
            Settings skip = new Settings();
            this.Hide();
            skip.Show();
        }
    }
}
