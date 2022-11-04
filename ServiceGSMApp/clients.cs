using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace ServiceGSMApp
{
    public partial class clients : Form
    {
        public clients()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();


        }


        private DataTable getlist()
        {
            
             
            DataTable dt = new DataTable();
            SqlConnection cnn;
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
            
             
            if (client.Text != "" && number.Text != "")
            {
                SqlConnection cnn;
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

                e.SuppressKeyPress = true;
            }
        }
    }
}
