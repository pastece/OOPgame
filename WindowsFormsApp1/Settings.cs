﻿using System;
using System.Text.RegularExpressions;
using System.IO;
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
    public partial class Settings : Form
    {
        int row;
        int column;
        string path = @".\save_settings.txt";
        
        public Settings()
        {
            InitializeComponent();
            if (File.Exists(path))
            {
                int count = 0;
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (count == 0)
                        {
                            if (line == "3 3") cmboxDiffuculty.SelectedIndex=0;
                            else if (line == "4 4") cmboxDiffuculty.SelectedIndex=1;
                            else if (line == "5 5") cmboxDiffuculty.SelectedIndex=2;
                            else
                            {
                                labelRow.Visible = true;
                                labelColumn.Visible = true;
                                textBoxRow.Visible = true;
                                textBoxColumn.Visible = true;
                                confirmBtn.Visible = true;

                                int c = 0;
                                string[] words = line.Split(' ');
                                foreach (var word in words)
                                {
                                    if (c == 0)
                                    {
                                        textBoxRow.Text = word;
                                        c++;
                                    }
                                    if(c==1)textBoxColumn.Text = word;
                                }
                                

                            }

                        }
                        if (count == 1)
                        {
                            string[] words = line.Split(' ');
                            foreach (var word in words)
                            {
                                if (word == "Square") squareBox.Checked = true;
                                if (word == "Triangle") triangleBox.Checked = true;
                                if (word == "Round") roundBox.Checked = true;


                            }

                           
                        }
                        if (count == 2)
                        {
                            string[] words = line.Split(' ');
                            foreach (var word in words)
                            {
                                if (word == "Blue") checkBoxBlue.Checked = true;
                                if (word == "Green") checkBoxGreen.Checked = true;
                                if (word == "Red") checkBoxRed.Checked = true;


                            }
                        }

                        count++;
                    }
                }

            }
        }

        private void customBtn_Click(object sender, EventArgs e)
        {
            labelRow.Visible = true;
            labelColumn.Visible = true;
            textBoxRow.Visible = true;
            textBoxColumn.Visible = true;
            confirmBtn.Visible = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cmboxDiffuculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxDiffuculty.Text == "Easy")
            {
                row = 3;
                column = 3;
            }
            if (cmboxDiffuculty.Text == "Medium")
            {
                row = 4;
                column = 4;
            }
            if (cmboxDiffuculty.Text == "Hard")
            {
                row = 5;
                column = 5;
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                row = int.Parse(textBoxRow.Text);
                column = int.Parse(textBoxColumn.Text);
            }
            catch (Exception)
            {
                DialogResult error = new DialogResult();
                error = MessageBox.Show("You have to enter a number", "Error", MessageBoxButtons.OK);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            string shape="";
            if (squareBox.Checked) shape += "Square ";
            if (triangleBox.Checked) shape += "Triangle ";
            if (roundBox.Checked) shape += "Round";

            string color = "";
            if (checkBoxBlue.Checked) color += "Blue ";
            if (checkBoxGreen.Checked) color += "Green ";
            if (checkBoxRed.Checked) color += "Red";

            string save = row.ToString() + " " + column.ToString() + Environment.NewLine
                + shape + Environment.NewLine + color;
                
            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(save);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

               
               
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}

