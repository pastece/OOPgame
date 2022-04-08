using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class profileScreen : Form
    {

        public static string username;
        public static string name;
        public static string phone;
        public static string adress;
        public static string city;
        public static string country;
        public static string email;
        public static string password;
        public profileScreen()
        {
            InitializeComponent();
        }

        private void profileScreen_Load(object sender, EventArgs e)
        {
            labelUserName.Text = username;
            textBoxName.Text = name;
            textBoxPhone.Text = phone;
            textBoxAdress.Text = adress;
            textBoxCity.Text = city;
            textBoxCountry.Text = country;
            textBoxEmail.Text = email;
            textBoxPassword.Text = "Password";

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            checkPassword check = new checkPassword();
            check.ShowDialog();

            if (password == checkPassword.vrfyPass)
            {
                textBoxName.Enabled = true;
                textBoxPhone.Enabled = true;
                textBoxAdress.Enabled = true;
                textBoxCity.Enabled = true;
                textBoxCountry.Enabled = true;
                textBoxEmail.Enabled = true;
                textBoxPassword.Enabled = true;
                buttonConfirm.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong password","Verify" , MessageBoxButtons.OK);
            }
            check.Dispose();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {


            XDocument xdosya = XDocument.Load(@"usersInfo.xml");
            XElement node = xdosya.Element("Users").Elements("User").FirstOrDefault(a => a.Element("UserName").Value.Trim() == username);

            if (node != null)
            {
                name = textBoxName.Text;
                phone = textBoxPhone.Text;
                adress = textBoxAdress.Text;
                city = textBoxCity.Text;
                country = textBoxCountry.Text;
                email = textBoxEmail.Text;

                
                node.SetElementValue("NameSurname", name);
                node.SetElementValue("PhoneNumber", phone);
                node.SetElementValue("Adress", adress);
                node.SetElementValue("City", city);
                node.SetElementValue("Country", country);
                node.SetElementValue("Email", email);
                xdosya.Save(@"usersInfo.xml");

                textBoxName.Enabled = false;
                textBoxPhone.Enabled = false;
                textBoxAdress.Enabled = false;
                textBoxCity.Enabled = false;
                textBoxCountry.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxPassword.Enabled = false;
                buttonConfirm.Visible = false;

                MessageBox.Show("            Saved");

            }

        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
            
            sfreGstr.Visible = true;


        }

        private void sfreGstr_CheckedChanged(object sender, EventArgs e)
        {
            if (sfreGstr.Checked)
            {
                textBoxPassword.PasswordChar = default;
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
}
