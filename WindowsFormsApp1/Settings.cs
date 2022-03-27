using System;
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
            mainGame skip = new mainGame();
            this.Hide();
            skip.Show();
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

            string save = row.ToString()+" "+column.ToString()+Environment.NewLine
                +shape;
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

