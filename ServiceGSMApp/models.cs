using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceGSMApp
{
    public partial class models : Form
    {
        public models()
        {
            
            InitializeComponent();
            getlist();
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

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM models", cnn))
            {
                cnn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            
            return dt;
        }

        private void models_Load(object sender, EventArgs e)
        {
            modelsgrid.DataSource = getlist();
            modelsgrid.Sort(modelsgrid.Columns[0], ListSortDirection.Ascending);
        }
        string tempnum;
        private void adding_Click(object sender, EventArgs e)
        {
            
             

            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "INSERT INTO models (Name) VALUES (@model);";
            cmd.Parameters.AddWithValue("@model", model.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();

            modelsgrid.DataSource = getlist();
            modelsgrid.Sort(modelsgrid.Columns[0], ListSortDirection.Ascending);
        }

        private void modelsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = modelsgrid.Rows[index];
                tempnum = selectedRow.Cells[0].Value.ToString();
                
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
           
             
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "DELETE FROM models WHERE Name=@model";
            cmd.Parameters.AddWithValue("@model", tempnum);
            cmd.ExecuteNonQuery();
            cnn.Close();

            modelsgrid.DataSource = getlist();
            modelsgrid.Sort(modelsgrid.Columns[0], ListSortDirection.Ascending);
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
                cmd.CommandText = "DELETE FROM models";
                cmd.ExecuteNonQuery();
                cnn.Close();

                modelsgrid.DataSource = getlist();
                modelsgrid.Sort(modelsgrid.Columns[0], ListSortDirection.Ascending);

            }
        }

        private void models_KeyDown(object sender, KeyEventArgs e)
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
