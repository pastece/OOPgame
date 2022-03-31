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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                mainGame skip = new mainGame();
                this.Hide();
                skip.Show();
            }
            else if(textBox1.Text == "user" && textBox2.Text == "user")
            {
                mainGame skip = new mainGame();
                this.Hide();
                skip.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı hatalı. Tekrar deneyiniz.");
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Do you want to close the program ? ", "Close", MessageBoxButtons.YesNo);

            if(secim == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if(secim == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void btnExitForm1_Click(object sender, EventArgs e)
        {
            Form1 kapat = new Form1();
            Application.ExitThread();
        }
    }
}
