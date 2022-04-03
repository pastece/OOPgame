using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public TextBox getTextbox1
        {
            get { return textBox1; }
        }

        public TextBox setTextbox1
        {
            set { textBox1 = value; }
        }
        public TextBox getTextbox2
        {
            get { return textBox2; }
        }

        public TextBox setTextbox2
        {
            set { textBox2 = value; }
        }

        


        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


 


        private void button1_Click(object sender, EventArgs e)
        {

            //new mainGame(this).Show();



            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                

                mainGame skip = new mainGame(this);
                this.Hide();
                skip.Show();

            }
            else if (textBox1.Text == "user" && textBox2.Text == "user")
            {
                mainGame skip = new mainGame(this);
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            signUp signup = new signUp();
            this.Hide();
            signup.Show();
        }
    }
}
