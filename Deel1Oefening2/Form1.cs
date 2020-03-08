using System;
using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Deel1Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Person.Person";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                label1.Text = cmd.ExecuteScalar().ToString();
            }
        }
    }
}
