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

namespace Deel1Oefening4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZoek_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Person.Person WHERE FirstName LIKE @Voornaam AND LastName LIKE @Naam";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString))
            {
                textBoxResultaat.ResetText();
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                //Hieronder 2 verschillende manieren om met parameters te werken, deze doen beiden hetzelfde, alleen geeft manier 1 iets meer controle en is manier 2 korter.
                // Manier 1:
                cmd.Parameters.Add("@Voornaam", SqlDbType.NVarChar);
                cmd.Parameters["@Voornaam"].Value = $"%{textBoxVoornaam.Text}%";
                // Manier 2:
                cmd.Parameters.AddWithValue("@Naam", $"%{textBoxNaam.Text}%");
                SqlDataReader reader = cmd.ExecuteReader();
                int nummer = 1;
                while (reader.Read())
                {
                    textBoxResultaat.AppendText(nummer++ + "\t" + reader.GetValue(4) + "\t" + reader.GetValue(6) + Environment.NewLine);
                }
            }
        }
    }
}
