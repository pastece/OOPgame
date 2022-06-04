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
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class profileScreen : Form
    {

        String connetionString = @"workstation id=OOPGAME.mssql.somee.com;packet size=4096;user id=pastace_SQLLogin_1;pwd=7xbcp7q2cu;data source=OOPGAME.mssql.somee.com;persist security info=False;initial catalog=OOPGAME";
        SqlConnection cnn;

        public static string username;
        public static string name;
        public static string phone;
        public static string adress;
        public static string city;
        public static string country;
        public static string email;
        public static string password;
        public static string score;
        
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
            labelScore.Text = "Best Score: " + score;

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
                password = Form1.ComputeSha256Hash(textBoxPassword.Text);

                
                node.SetElementValue("NameSurname", name);
                node.SetElementValue("PhoneNumber", phone);
                node.SetElementValue("Adress", adress);
                node.SetElementValue("City", city);
                node.SetElementValue("Country", country);
                node.SetElementValue("Email", email);
                node.SetElementValue("Password", password);

                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand sqlCommand = new SqlCommand("Update oopUsers set NameSurname = @name ,PhoneNumber = @phone, Adress=@adress, City=@city, Country=@country, Email=@email where UserName = @uname", cnn);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@uname", username);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@adress", adress);
                sqlCommand.Parameters.AddWithValue("@city", city);
                sqlCommand.Parameters.AddWithValue("@country", country);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.ExecuteNonQuery();
                xdosya.Save(@"usersInfo.xml");

                cnn.Close();

                textBoxName.Enabled = false;
                textBoxPhone.Enabled = false;
                textBoxAdress.Enabled = false;
                textBoxCity.Enabled = false;
                textBoxCountry.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxPassword.Enabled = false;
                buttonConfirm.Visible = false;
                pictureBox1.Visible = false;
                sfreGstr.Visible = false;

                MessageBox.Show("            Saved");

            }

        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
            
            sfreGstr.Visible = true;
            pictureBox1.Visible = true;

        }

        private void sfreGstr_CheckedChanged(object sender, EventArgs e)
        {
            if (sfreGstr.Checked)
            {
                textBoxPassword.PasswordChar = default;
                pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.open;

            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.visibility;

            }
        }

        private void profileScreen_FormClosing(object sender, FormClosingEventArgs e)
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

        
    }
}
