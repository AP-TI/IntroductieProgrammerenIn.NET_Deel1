using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deel1Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT TOP 100 * FROM Person.Person";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                int nummer = 1;
                while (reader.Read())
                {
                    textBox1.AppendText(nummer++ + "\t" + reader.GetValue(4) + "\t" + reader.GetValue(6) + Environment.NewLine);
                }
            }
        }
    }
}
