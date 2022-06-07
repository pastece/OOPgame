using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Scores : Form
    {
        String connetionString = @"workstation id=OOPGAME.mssql.somee.com;packet size=4096;user id=pastace_SQLLogin_1;pwd=7xbcp7q2cu;data source=OOPGAME.mssql.somee.com;persist security info=False;initial catalog=OOPGAME";
        SqlConnection cnn;
        bool desc = true;
        public Scores()
        {
            InitializeComponent();
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UserName, Score FROM oopUsers ORDER BY Score DESC", cnn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string[] row = { dataTable.Rows[i]["UserName"].ToString(), dataTable.Rows[i]["Score"].ToString() };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
            }


            cnn.Close();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            listView1.Items.Clear();


            if (desc)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UserName, Score FROM oopUsers ORDER BY Score ASC", cnn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string[] row = { dataTable.Rows[i]["UserName"].ToString(), dataTable.Rows[i]["Score"].ToString() };
                    var satir = new ListViewItem(row);
                    listView1.Items.Add(satir);
                }
                desc = false;
            }

            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT UserName, Score FROM oopUsers ORDER BY Score DESC", cnn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string[] row = { dataTable.Rows[i]["UserName"].ToString(), dataTable.Rows[i]["Score"].ToString() };
                    var satir = new ListViewItem(row);
                    listView1.Items.Add(satir);
                }
                desc = true;
            }



            


            cnn.Close();
        }
    }
}
