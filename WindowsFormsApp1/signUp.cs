using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{

    
    public partial class signUp : Form
    {
       
        
        public signUp()
        {
            InitializeComponent();
        }

        managerScreen mng = (managerScreen)Application.OpenForms["managerScreen"];
        String connetionString = @"workstation id=OOPGAME.mssql.somee.com;packet size=4096;user id=pastace_SQLLogin_1;pwd=7xbcp7q2cu;data source=OOPGAME.mssql.somee.com;persist security info=False;initial catalog=OOPGAME";
        SqlConnection cnn;


        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["managerScreen"];
            if (fc != null)
            {
                managerScreen mngscreen = new managerScreen();
                this.Hide();

            }

            else
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
        }

        private void signUp_FormClosing(object sender, FormClosingEventArgs e)
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

        private void signUp_Load(object sender, EventArgs e)
        {
            
            
        }

        bool IsValidEmail(string eMail)
        {
            bool Result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
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
        private void buttonSign_Click(object sender, EventArgs e)
        {

            Form fc = Application.OpenForms["managerScreen"];
            string sha256 = ComputeSha256Hash(textBoxPassword.Text);

            cnn = new SqlConnection(connetionString);
            cnn.Open();

            if (fc != null)
            {
                XDocument x = XDocument.Load(@"usersInfo.xml");
                x.Element("Users").Add(
                    new XElement("User",
                    new XElement("UserName", textBoxUserName.Text),
                    new XElement("Password", sha256),
                    new XElement("NameSurname", textBoxName.Text),
                    new XElement("PhoneNumber", maskedTextBoxPhone.Text),
                    new XElement("Adress", textBoxAdress.Text),
                    new XElement("City", textBoxCity.Text),
                    new XElement("Country", textBoxCity.Text),
                    new XElement("Email", textBoxEmail.Text),
                    new XElement("Score", "0")


                    ));
                x.Save(@"usersInfo.xml");
                MessageBox.Show("Successful Registration");
                mng.usersList();
;
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (textBox.Text == string.Empty)
                        {
                            MessageBox.Show(textBox.Name + "  is empthy, please enter a value.");
                            return;

                        }

                    }
                }
                if (!IsValidEmail(textBoxEmail.Text))
                {
                    MessageBox.Show("You have to enter a valid email");
                    return;
                }
                if (textBoxUserName.Text == "admin")
                {
                    MessageBox.Show("User name can't be 'admin'");
                    return;
                }
                if (maskedTextBoxPhone.Text.Length != 15)
                {
                    MessageBox.Show("Phone number is missing");
                    return;
                }
                //xml'e kaydetme
                XDocument xdosya = XDocument.Load(@"usersInfo.xml");
                XElement rootElement = xdosya.Root;
                XElement element = new XElement("User");
                XElement UserName = new XElement("UserName", textBoxUserName.Text);
                XElement Password = new XElement("Password", sha256);
                XElement NameSurname = new XElement("NameSurname", textBoxName.Text);
                XElement PhoneNumber = new XElement("PhoneNumber", maskedTextBoxPhone.Text);
                XElement Adress = new XElement("Adress", textBoxAdress.Text);
                XElement City = new XElement("City", textBoxCity.Text);
                XElement Country = new XElement("Country", textBoxCountry.Text);
                XElement Email = new XElement("Email", textBoxEmail.Text);
                XElement Score = new XElement("Score", 0);
                

                //sql'e kaydetme
                SqlCommand sqlCommand = new SqlCommand("Insert into oopUsers  (UserName, NameSurname, PhoneNumber, Adress, City, Country, Email, Score) Values (@username, @name, @phone, @adress, @city, @country, @email, @score)", cnn);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@username", textBoxUserName.Text);
                sqlCommand.Parameters.AddWithValue("@name", textBoxName.Text);
                sqlCommand.Parameters.AddWithValue("@phone", maskedTextBoxPhone.Text);
                sqlCommand.Parameters.AddWithValue("@adress", textBoxAdress.Text);
                sqlCommand.Parameters.AddWithValue("@city", textBoxCity.Text);
                sqlCommand.Parameters.AddWithValue("@country", textBoxCountry.Text);
                sqlCommand.Parameters.AddWithValue("@email", textBoxEmail.Text);
                sqlCommand.Parameters.AddWithValue("@score", 0);
                sqlCommand.ExecuteNonQuery();

                cnn.Close();

                element.Add(UserName, Password, NameSurname, PhoneNumber, Adress, City, Country, Email, Score);
                rootElement.Add(element);
                xdosya.Save(@"usersInfo.xml");

                MessageBox.Show("Successful Registration");
            }
        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            labelUserName.Visible = false;
        }
        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if(textBoxUserName.Text==string.Empty)
                labelUserName.Visible = true;
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            labelName.Visible = false;
        }
        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty)
                labelName.Visible = true;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == string.Empty)
                labelPassword.Visible = true;
        }

        private void maskedTextBoxPhone_Enter(object sender, EventArgs e)
        {
            maskedTextBoxPhone.ForeColor = Color.Black;
        }

        private void maskedTextBoxPhone_Leave(object sender, EventArgs e)
        {
            if(maskedTextBoxPhone.Text==string.Empty)
                maskedTextBoxPhone.ForeColor = Color.SlateGray;

        }

        private void textBoxAdress_Enter(object sender, EventArgs e)
        {
            labelAdress.Visible = false;
        }
        private void textBoxAdress_Leave(object sender, EventArgs e)
        {
            if (textBoxAdress.Text == string.Empty)
                labelAdress.Visible = true;
        }

        private void textBoxCity_Enter(object sender, EventArgs e)
        {
            labelCity.Visible = false;
        }
        private void textBoxCity_Leave(object sender, EventArgs e)
        {
            if (textBoxCity.Text == string.Empty)
                labelCity.Visible = true;
        }

        private void textBoxCountry_Enter(object sender, EventArgs e)
        {
            labelCountry.Visible = false;
        }
        private void textBoxCountry_Leave(object sender, EventArgs e)
        {
            if (textBoxCountry.Text == string.Empty)
                labelCountry.Visible = true;
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            labelEmail.Visible = false;
        }
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == string.Empty)
                labelEmail.Visible = true;
        }

        private void signUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSign.PerformClick();
            }
        }

       
    }
}
