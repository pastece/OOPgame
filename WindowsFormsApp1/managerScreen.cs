using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class managerScreen : Form
    {
        public managerScreen()
        {
            InitializeComponent();

        }

        private void managerScreen_Load(object sender, EventArgs e)
        {
            usersList();

        }

        bool IsValidEmailmng(string eMail)
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

        public void usersList()
        {
            try
            {

                XmlDocument xdosya = new XmlDocument();
                DataSet dSet = new DataSet();
                XmlReader reader = XmlReader.Create(@"usersInfo.xml", new XmlReaderSettings());
                dSet.ReadXml(reader);
                dtGridList.DataSource = dSet.Tables[0];
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       
        

        private void backBtnMs_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            signUp skip = new signUp();
            skip.Show();

        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            XDocument xdosya = XDocument.Load(@"usersInfo.xml");
            XElement node = xdosya.Element("Users").Elements("User").FirstOrDefault(a => a.Element("UserName").Value.Trim() == txtBoxUserName.Text);

            if (node != null)
            {
                node.SetElementValue("NameSurname", txtBoxNameSurname.Text);
                node.SetElementValue("PhoneNumber", txtBoxPhoneNumber.Text);
                node.SetElementValue("Adress", txtBoxAddress.Text);
                node.SetElementValue("City", txtBoxCity.Text);
                node.SetElementValue("Country", txtBoxCountry.Text);
                node.SetElementValue("Email", txtBoxEmail.Text);
                xdosya.Save(@"usersInfo.xml");
                usersList();
                
                if (!IsValidEmailmng(txtBoxEmail.Text))
                {
                    MessageBox.Show("You have to enter a valid email");
                    return;
                }
                
                
                if (txtBoxPhoneNumber.Text.Length != 15)
                {
                    MessageBox.Show("Phone number is missing");
                    return;
                }


                txtBoxUserName.Clear();
                txtBoxNameSurname.Clear();
                txtBoxPhoneNumber.Clear();
                txtBoxAddress.Clear();
                txtBoxCity.Clear();
                txtBoxCountry.Clear();
                txtBoxEmail.Clear();
                

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            XDocument xdosya = XDocument.Load(@"usersInfo.xml");
            xdosya.Root.Elements().Where(a => a.Element("UserName").Value == txtBoxUserName.Text).Remove();
            xdosya.Save(@"usersInfo.xml");
            usersList();
            txtBoxUserName.Clear();

        }

        private void txtBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        
    }
}
