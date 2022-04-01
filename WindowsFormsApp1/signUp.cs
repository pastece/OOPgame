﻿using System;
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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "User Name")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;

            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                textBoxUserName.ForeColor = Color.SlateGray;
                textBoxUserName.Text = "User Name";
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
            textBoxPassword.PasswordChar = '*';

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.PasswordChar = default;
                textBoxPassword.ForeColor = Color.SlateGray;

            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Name-Surname")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;

            }

        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Name-Surname";
                textBoxName.ForeColor = Color.SlateGray;
            }

        }

       

        private void textBoxAdress_Enter(object sender, EventArgs e)
        {
            if (textBoxAdress.Text == "Adress") {
                textBoxAdress.Text = "";
                textBoxAdress.ForeColor = Color.Black;
            }

        }

        private void textBoxAdress_Leave(object sender, EventArgs e)
        {
            if (textBoxAdress.Text == "") {
                textBoxAdress.Text = "Adress";
                textBoxAdress.ForeColor = Color.SlateGray;
            }

        }

        private void textBoxCity_Enter(object sender, EventArgs e)
        {
            if (textBoxCity.Text == "City") {
                textBoxCity.Text = "";
                textBoxCity.ForeColor = Color.Black;
            }

        }

        private void textBoxCity_Leave(object sender, EventArgs e)
        {
            if (textBoxCity.Text == "") {
                textBoxCity.Text = "City";
                textBoxCity.ForeColor = Color.SlateGray;
            }

        }

        private void textBoxCountry_Enter(object sender, EventArgs e)
        {
            if (textBoxCountry.Text == "Country") {
                textBoxCountry.Text = "";
                textBoxCountry.ForeColor = Color.Black;
            }

        }

        private void textBoxCountry_Leave(object sender, EventArgs e)
        {
            if (textBoxCountry.Text == "") {
                textBoxCountry.Text = "Country";
                textBoxCountry.ForeColor = Color.SlateGray;
            }

        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }

        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "") {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.SlateGray;
            }

        }

        private void maskedTextBoxPhone_Enter(object sender, EventArgs e)
        {
            maskedTextBoxPhone.ForeColor = Color.Black;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
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
    }
}
