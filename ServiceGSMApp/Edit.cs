using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceGSMApp
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            LoadModels();
            LoadReceipt();
            LoadMester();
            LoadName();
            LoadContact();
        }

        private void LoadModels()
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.conn))
            {
                connection.Open();
                var query = "SELECT Name FROM models";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {

                            model.Items.Add(reader["Name"]);
                        }
                    }
                }
            }
        }


        private void LoadReceipt()
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.conn))
            {
                connection.Open();
                var query = "SELECT Name FROM reception";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {

                            receipt.Items.Add(reader["Name"]);
                        }
                    }
                }
            }
        }

        private void LoadName()
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.conn))
            {
                connection.Open();
                var query = "SELECT Name FROM clients";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {

                            name.Items.Add(reader["Name"]);
                        }
                    }
                }
            }
        }
        private void LoadContact()
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.conn))
            {
                connection.Open();
                var query = "SELECT Contact FROM clients";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {

                            contact.Items.Add(Convert.ToString(reader["Contact"]));
                        }
                    }
                }
            }
        }
        private void LoadMester()
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.conn))
            {
                connection.Open();
                var query = "SELECT Name FROM reception";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {

                            mester.Items.Add(Convert.ToString(reader["Name"]));
                        }
                    }
                }
            }
        }
        public string numbertemp;
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public bool list;

        

       
        

        private void timer_Tick(object sender, EventArgs e)
        {
            if (mester.Text == "") { mester.Enabled = false; donetime.Enabled = false; } else { mester.Enabled = true; donetime.Enabled = true; }
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            string query;
            if (mester.Text != "") { query = "SELECT * FROM doneorders WHERE Number = @nr AND Name = @nume AND Model=@model"; }
            else { query = "SELECT * FROM comenzi WHERE Number = @nr AND Name = @nume AND Model=@model"; }
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@nr", Convert.ToInt32(numbertemp));
            cmd.Parameters.AddWithValue("@nume", Convert.ToString(name.Text));
            cmd.Parameters.AddWithValue("@model", Convert.ToString(model.Text));
            int ap, lucr, scr, cg;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                mester.Text = String.Format("{0}", reader["Master"]);
                contact.Text = String.Format("{0}", reader["Contact"]);
                imei.Text = String.Format("{0}", reader["IMEI"]);
                if (imei.Text == "0") imei.Text = "";
                model.Text = String.Format("{0}", reader["Model"]);
                receipt.Text = String.Format("{0}", reader["Receipt"]);
                details.Text = String.Format("{0}", reader["Details"]);
                problems.Text = String.Format("{0}", reader["Problems"]);
                ap = Convert.ToInt32(reader["Water"]);
                if (ap == 1) water.Checked = true; else water.Checked = false;
                lucr = Convert.ToInt32(reader["Reaction"]);
                if (lucr == 1) reaction.Checked = true; else reaction.Checked = false;
                cg = Convert.ToInt32(reader["Charger"]);
                if (cg == 1) charger.Checked = true; else charger.Checked = false;
                scr = Convert.ToInt32(reader["Scratches"]);
                if (scr == 1) scratches.Checked = true; else scratches.Checked = false;
                dataprimb.Value = Convert.ToDateTime(reader["DateReceipt"]);

                price.Text = Convert.ToString(reader["Price"]);
            }
            cnn.Close();
            timer.Enabled = false;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            
            
            
                using (var connection = new SqlConnection(Properties.Settings.Default.conn))
                {


                    connection.Open();
                    SqlCommand comm = connection.CreateCommand();

                if (mester.Text == "")
                { 
                    comm.CommandText = "UPDATE comenzi SET DateReceipt=@date, Receipt=@receipt, Details=@details, IMEI = @imei ,Name=@name , Model=@model, Contact=@contact, Problems=@problems, Price=@price, Water=@water, Reaction=@reaction, Charger=@charger, Scratches=@scratches WHERE Number=@number";
                    comm.Parameters.AddWithValue("@date", dataprimb.Value);
                    comm.Parameters.AddWithValue("@receipt", receipt.Text);
                    comm.Parameters.AddWithValue("@model", model.Text);
                    comm.Parameters.AddWithValue("@details", details.Text);
                    comm.Parameters.AddWithValue("@problems", problems.Text);
                    if (price.Text == "") { comm.Parameters.AddWithValue("@price", 0); }
                    else { comm.Parameters.AddWithValue("@price", Convert.ToInt32(price.Text)); }
                    if (imei.Text == "") { comm.Parameters.AddWithValue("@imei", 0); }
                    else
                    { comm.Parameters.AddWithValue("@imei", Convert.ToInt32(imei.Text)); }
                    comm.Parameters.AddWithValue("@contact", Convert.ToInt32(contact.Text));
                    if (water.Checked == true) { comm.Parameters.AddWithValue("@water", 1); } else { comm.Parameters.AddWithValue("@water", 0); }
                    if (reaction.Checked == true) { comm.Parameters.AddWithValue("@reaction", 1); } else { comm.Parameters.AddWithValue("@reaction", 0); }
                    if (charger.Checked == true) { comm.Parameters.AddWithValue("@charger", 1); } else { comm.Parameters.AddWithValue("@charger", 0); }
                    if (scratches.Checked == true) { comm.Parameters.AddWithValue("@scratches", 1); } else { comm.Parameters.AddWithValue("@scratches", 0); }
                    comm.Parameters.AddWithValue("@name", name.Text);
                    comm.Parameters.AddWithValue("@number", numbertemp);
                    comm.ExecuteNonQuery();
                }
                else 
                { 
                    comm.CommandText = "UPDATE doneorders SET DateReceipt=@date, DateFinish=@datefin, Master=@master, Receipt=@receipt, Details=@details, IMEI = @imei ,Name=@name , Model=@model, Contact=@contact, Problems=@problems, Price=@price, Water=@water, Reaction=@reaction, Charger=@charger, Scratches=@scratches WHERE Number=@number";
                    comm.Parameters.AddWithValue("@date", dataprimb.Value);
                    comm.Parameters.AddWithValue("@receipt", receipt.Text);
                    comm.Parameters.AddWithValue("@datefin", donetime.Value);
                    comm.Parameters.AddWithValue("@master", mester.Text);
                    comm.Parameters.AddWithValue("@model", model.Text);
                    comm.Parameters.AddWithValue("@details", details.Text);
                    comm.Parameters.AddWithValue("@problems", problems.Text);
                    if (price.Text == "") { comm.Parameters.AddWithValue("@price", 0); }
                    else { comm.Parameters.AddWithValue("@price", Convert.ToInt32(price.Text)); }
                    if (imei.Text == "") { comm.Parameters.AddWithValue("@imei", 0); }
                    else
                    { comm.Parameters.AddWithValue("@imei", Convert.ToInt32(imei.Text)); }
                    comm.Parameters.AddWithValue("@contact", Convert.ToInt32(contact.Text));
                    if (water.Checked == true) { comm.Parameters.AddWithValue("@water", 1); } else { comm.Parameters.AddWithValue("@water", 0); }
                    if (reaction.Checked == true) { comm.Parameters.AddWithValue("@reaction", 1); } else { comm.Parameters.AddWithValue("@reaction", 0); }
                    if (charger.Checked == true) { comm.Parameters.AddWithValue("@charger", 1); } else { comm.Parameters.AddWithValue("@charger", 0); }
                    if (scratches.Checked == true) { comm.Parameters.AddWithValue("@scratches", 1); } else { comm.Parameters.AddWithValue("@scratches", 0); }
                    comm.Parameters.AddWithValue("@name", name.Text);
                    comm.Parameters.AddWithValue("@number", numbertemp);
                    comm.ExecuteNonQuery();
                }
                    //@date,@receipt,@number,@name,@model,@imei,@details,@water,@react,@charg,@scrat,@problems,@contact,@cond,@price
                    
                    connection.Close();

                    
                }
            this.Hide();
        }
    }
}
