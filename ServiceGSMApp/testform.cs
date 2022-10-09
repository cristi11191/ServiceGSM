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
using System.IO;

namespace ServiceGSMApp
{
    public partial class testform : Form
    {
        public testform()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Test VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "') ";
            cmd.Connection = conn;
            conn.Open();

            cmd.ExecuteNonQuery();
            
            conn.Close();

        }

        private void testform_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Test WHERE Name=@nm";
            cmd.Parameters.AddWithValue("@nm", "Masf");
            cmd.Connection = conn;
            conn.Open();
            var reader = cmd.ExecuteReader();
            dt.Load(reader);
            dataGridView1.AutoSize = true;
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
