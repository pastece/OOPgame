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
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            About skip = new About();
            this.Hide();
            skip.Show();
        }

        private void HelpScreenBck_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
