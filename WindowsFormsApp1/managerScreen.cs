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

        public void usersList()
        {
            DataSet dSet = new DataSet();
            XmlReader reader = XmlReader.Create(@"usersInfo.xml", new XmlReaderSettings());
            dSet.ReadXml(reader);
            dtGridList.DataSource = dSet.Tables[0];
            reader.Close();
        }

       
    }
}
