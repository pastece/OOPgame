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
    public partial class checkPassword : Form
    {
        public static string vrfyPass;

        public checkPassword()
        {
            InitializeComponent();
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            vrfyPass = Form1.ComputeSha256Hash(textBoxVerify.Text);
            this.Hide();
            
        }

       
    }
}
