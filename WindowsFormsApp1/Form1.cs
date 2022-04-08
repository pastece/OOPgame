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
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1
{

    //yorumsatırı
    public partial class Form1 : Form
    {
        public string userName
        {
            get { return textBox1.Text; }
        }
        
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

        public static string ComputeSha256Hash(string rawData)
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
            string pass;

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

                XDocument xdosya = XDocument.Load(@"usersInfo.xml");
                XElement node = xdosya.Element("Users").Elements("User").FirstOrDefault(a => a.Element("UserName").Value.Trim() == textBox1.Text);

                if (node != null)
                {
                    pass = ComputeSha256Hash(textBox2.Text);
                    if (node.Element("Password").Value == pass)
                    {
                        profileScreen.username = node.Element("UserName").Value;
                        profileScreen.password = node.Element("Password").Value;
                        profileScreen.name=node.Element("NameSurname").Value;
                        profileScreen.phone=node.Element("PhoneNumber").Value;
                        profileScreen.adress=node.Element("Adress").Value;
                        profileScreen.city=node.Element("City").Value;
                        profileScreen.country=node.Element("Country").Value;
                        profileScreen.email=node.Element("Email").Value;

                        mainGame skip = new mainGame(this);
                        this.Hide();
                        skip.Show();
                    }
                    else
                    {
                        MessageBox.Show("User name or password is wrong, try again.");
                        textBox1.Clear();
                        textBox2.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("User name or password is wrong, try again.");
                    textBox1.Clear();
                    textBox2.Clear();
                }

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);

        }

        private void sfreGstr_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (sfreGstr.Checked)
            {
                //karakteri göster.
                textBox2.PasswordChar = '\0';
                pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.open;

            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox2.PasswordChar = '*';
                pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.visibility;

            }
        }

        
    }
}
