using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceGSMApp
{
    public partial class clients : Form
    {
        public clients()
        {
            citirebd();
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        string source;
        string database;
        string username;
        string password;
        string ssl;
        int counter;
        private void citirebd()
        {
            var path = "bdsettings.txt";
            using (StreamReader reader = new StreamReader(path))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    counter++;
                    switch (counter)
                    {
                        case 1: source = line; break;
                        case 2: database = line; break;
                        case 3: username = line; break;
                        case 4: password = line; break;
                        default: ssl = line; break;
                    }
                }
            }

        }



        private DataTable getlist()
        {
            DataTable dt = new DataTable();
            SqlConnection cnn;
            string connectionString;
            connectionString = "datasource =" + source + "; database=" + database + "; username=" + username + "; password=" + password + "; SslMode = " + ssl;
            cnn = new SqlConnection(Properties.Settings.Default.conn);

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM clients", cnn))
            {
                cnn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }

            return dt;
        }

        private void clients_Load(object sender, EventArgs e)
        {
            clientsgrid.DataSource = getlist();
            clientsgrid.Sort(clientsgrid.Columns[0], ListSortDirection.Ascending);
        }

        
        string tempnum;
        string tempnr;
        private void clientsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = clientsgrid.Rows[index];
                tempnum = selectedRow.Cells[0].Value.ToString();
                tempnr = selectedRow.Cells[1].Value.ToString();
            }
        }

        private void adding_Click(object sender, EventArgs e)
        {
            if (client.Text != "" && number.Text !="")
            {
                SqlConnection cnn;
                string connectionString;
                connectionString = "datasource =" + source + "; database=" + database + "; username=" + username + "; password=" + password + "; SslMode = " + ssl;
                cnn = new SqlConnection(Properties.Settings.Default.conn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "INSERT INTO clients(Name, Contact) VALUES (@client,@number);";
                cmd.Parameters.AddWithValue("@client", client.Text);
                cmd.Parameters.AddWithValue("@number", number.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();

                clientsgrid.DataSource = getlist();
                clientsgrid.Sort(clientsgrid.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString;
            connectionString = "datasource =" + source + "; database=" + database + "; username=" + username + "; password=" + password + "; SslMode = " + ssl;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "DELETE FROM clients WHERE Name=@client AND Contact=@number";
            cmd.Parameters.AddWithValue("@client", tempnum);
            cmd.Parameters.AddWithValue("@number", tempnr);
            cmd.ExecuteNonQuery();
            cnn.Close();

            clientsgrid.DataSource = getlist();
            clientsgrid.Sort(clientsgrid.Columns[0], ListSortDirection.Ascending);
        }

        private void clearlist_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Administraton == "1")
            {
                SqlConnection cnn;
                string connectionString;
                connectionString = "datasource =" + source + "; database=" + database + "; username=" + username + "; password=" + password + "; SslMode = " + ssl;
                cnn = new SqlConnection(Properties.Settings.Default.conn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "DELETE FROM clients";
                cmd.ExecuteNonQuery();
                cnn.Close();

                clientsgrid.DataSource = getlist();
                clientsgrid.Sort(clientsgrid.Columns[0], ListSortDirection.Ascending);

            }

        }

        private void clients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

                // prevent child controls from handling this event as well
                e.SuppressKeyPress = true;
            }
        }
    }
}
