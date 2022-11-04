using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiceGSMApp
{
    public partial class Add : Form
    {
        private readonly Comenzi frm1;
        public Add(Comenzi frm)
        {
            
            InitializeComponent();
            LoadModels();
            LoadReceipt();
            
            LoadName();
            LoadContact();
            frm1 = frm;
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
                        while (reader.Read())
                        {

                            receipt.Items.Add(reader["Name"]);
                        }
                    }
                }
            }
            if (Properties.Settings.Default.receptnow == "") { receipt.SelectedIndex = 0; } else { receipt.Text = Properties.Settings.Default.receptnow; }

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
                        while (reader.Read())
                        {

                            contact.Items.Add(Convert.ToString(reader["Contact"]));
                        }
                    }
                }
            }
        }
        
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        string num;
        private void addbtn_Click(object sender, EventArgs e)
        {
            
             

            if ( name.Text == "" && model.Text == "" &&  details.Text == "" && contact.Text == "" )
            { MessageBox.Show("Зaполните все поля с знаком * "); } else {
                using (var connection = new SqlConnection(Properties.Settings.Default.conn))
                {
                    connection.Open();
                    SqlCommand comm = connection.CreateCommand();
                    comm.CommandText = "INSERT INTO comenzi(DateReceipt, Receipt, Name, Model,IMEI, Details, Water, Reaction, Charger, Scratches, Problems, Contact, Condition, Price) VALUES (@date,@receipt,@name,@model,@imei,@details,@water,@react,@charg,@scrat,@problems,@contact,@cond,@price)";
                    comm.Parameters.AddWithValue("@date", dataprimb.Value);
                    comm.Parameters.AddWithValue("@receipt", receipt.Text);
                    comm.Parameters.AddWithValue("@name", name.Text);
                    comm.Parameters.AddWithValue("@model", model.Text);
                    if (imei.Text == "") { comm.Parameters.AddWithValue("@imei", 0); }
                    else
                    { comm.Parameters.AddWithValue("@imei", Convert.ToInt32(imei.Text)); }
                    comm.Parameters.AddWithValue("@details", details.Text);
                    if (water.Checked == true) { comm.Parameters.AddWithValue("@water", 1); } else { comm.Parameters.AddWithValue("@water", 0); }
                    if (reaction.Checked == true) { comm.Parameters.AddWithValue("@react", 1); } else { comm.Parameters.AddWithValue("@react", 0); }
                    if (charger.Checked == true) { comm.Parameters.AddWithValue("@charg", 1); } else { comm.Parameters.AddWithValue("@charg", 0); }
                    if (scratches.Checked == true) { comm.Parameters.AddWithValue("@scrat", 1); } else { comm.Parameters.AddWithValue("@scrat", 0); }
                    comm.Parameters.AddWithValue("@problems", problems.Text);
                    comm.Parameters.AddWithValue("@contact", Convert.ToInt32(contact.Text));
                    comm.Parameters.AddWithValue("@cond", "В ожидании");
                    if (price.Text == "") { comm.Parameters.AddWithValue("@price", 0); }
                    else { comm.Parameters.AddWithValue("@price", Convert.ToInt32(price.Text)); }

                    comm.ExecuteNonQuery();
                    connection.Close();
                }
                
                

                SqlConnection cnn;
                cnn = new SqlConnection(Properties.Settings.Default.conn);
                cnn.Open();
                string query = "SELECT Number FROM comenzi WHERE Name=@name AND Details=@det AND Price=@price";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@det", details.Text);
                cmd.Parameters.AddWithValue("@price", price.Text);


                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    num = Convert.ToString(reader["Number"]);
                }
                cnn.Close();



                if (!name.Items.Contains(name.Text))
                {

                    using (var connection = new SqlConnection(Properties.Settings.Default.conn))
                    {
                        connection.Open();
                        SqlCommand comm = connection.CreateCommand();
                        comm.CommandText = "INSERT INTO clients(Name, Contact) VALUES (@name,@contact)";
                        comm.Parameters.AddWithValue("@name", name.Text);
                        comm.Parameters.AddWithValue("@contact", Convert.ToInt32(contact.Text));

                        comm.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                
                Comenzi comen = new Comenzi();
                int imeei;
                if (imei.Text == "") { imeei = 0; }
                else
                { imeei = Convert.ToInt32(imei.Text); }
                comen.comenzidatagrid.DataSource = comen.getlist();
                comen.comenzidatagrid.Sort(comen.comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                string watr, reacti, bp, scr;
                if (water.Checked == true) { watr = "Попадание влаги"; } else { watr = ""; }
                if (reaction.Checked == true) { reacti = "Нет реакций"; } else { reacti = ""; }
                if (charger.Checked == true) { bp = "Нет Б.П. (Ноутбук)"; } else { bp = ""; }
                if (scratches.Checked == true) { scr = "Царапины"; } else { scr = ""; }
                using (fstReceipt prt = new fstReceipt())
                {
                ReportParameter[] para = new ReportParameter[]
                {
                new ReportParameter("FName", Properties.Settings.Default.NameOrg),
                new ReportParameter("FAdress", Properties.Settings.Default.AdressOrg),
                new ReportParameter("FPhone", Properties.Settings.Default.ContactOrg),
                new ReportParameter("FWork", Properties.Settings.Default.TimeOrg),
                new ReportParameter("FLogo", new Uri(Properties.Settings.Default.FileString).AbsoluteUri),
                new ReportParameter("Nr", num),
                new ReportParameter("Date", dataprimb.Text),
                new ReportParameter("Name", name.Text),
                new ReportParameter("Phone", contact.Text),
                new ReportParameter("Model", model.Text),
                new ReportParameter("IMEI", Convert.ToString(imeei)),
                new ReportParameter("Reception", "("+ receipt.Text +")"),
                new ReportParameter("Client", "("+ name.Text +")"),
                new ReportParameter("Service", details.Text),
                new ReportParameter("water", watr),
                new ReportParameter("react", reacti),
                new ReportParameter("charg", bp),
                new ReportParameter("scrat", scr),
                 };
                    prt.reportViewer1.LocalReport.EnableExternalImages = true;
                    prt.reportViewer1.LocalReport.SetParameters(para);
                    prt.ShowDialog();
                }
                Properties.Settings.Default.receptnow = receipt.Text;
                Properties.Settings.Default.Save();
                frm1.refreshgrid();
                this.Hide();
            }
        }

        

        private void imei_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(imei.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста вводите только цифры.");
                imei.Text = imei.Text.Remove(imei.Text.Length - 1);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(imei.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста вводите только цифры.");
                imei.Text = imei.Text.Remove(imei.Text.Length - 1);
            }
        }

        private void contact_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(contact.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста вводите только цифры.");
                contact.Text = contact.Text.Remove(contact.Text.Length - 1);
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(price.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста вводите только цифры.");
                price.Text = price.Text.Remove(price.Text.Length - 1);
            }
        }

        private void contact_SelectedIndexChanged(object sender, EventArgs e)
        {
            name.SelectedIndex = contact.SelectedIndex;
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            contact.SelectedIndex = name.SelectedIndex;
        }
        bool vis;
        private void sett_Click(object sender, EventArgs e)
        {
            
            if (vis == true)
            {
                clientbtn.Visible = false;
                modelbtn.Visible = false;
                vis = false;
            }
            else
            {
                clientbtn.Visible = true;
                modelbtn.Visible = true;
                vis = true;
            }
        }

        private void modelbtn_Click(object sender, EventArgs e)
        {
            models model = new models();
            model.Show();
        }

        private void clientbtn_Click(object sender, EventArgs e)
        {
            clients client = new clients();
            client.Show();
        }

        private void dataprimb_ValueChanged(object sender, EventArgs e)
        {
            dataprimb.MinDate = DateTime.Now;
        }

        private void Add_KeyDown(object sender, KeyEventArgs e)
        {
            
             
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter)
            {

                if (name.Text == "" && model.Text == "" && details.Text == "" && contact.Text == "")
                { MessageBox.Show("Зaполните все поля с знаком * "); }
                else
                {
                    using (var connection = new SqlConnection(Properties.Settings.Default.conn))
                    {
                        connection.Open();
                        SqlCommand comm = connection.CreateCommand();
                        comm.CommandText = "INSERT INTO comenzi(DateReceipt, Receipt, Name, Model,IMEI, Details, Water, Reaction, Charger, Scratches, Problems, Contact, Condition, Price) VALUES (@date,@receipt,@name,@model,@imei,@details,@water,@react,@charg,@scrat,@problems,@contact,@cond,@price)";
                        comm.Parameters.AddWithValue("@date", dataprimb.Value);
                        comm.Parameters.AddWithValue("@receipt", receipt.Text);
                        comm.Parameters.AddWithValue("@name", name.Text);
                        comm.Parameters.AddWithValue("@model", model.Text);
                        if (imei.Text == "") { comm.Parameters.AddWithValue("@imei", 0); }
                        else
                        { comm.Parameters.AddWithValue("@imei", Convert.ToInt32(imei.Text)); }
                        comm.Parameters.AddWithValue("@details", details.Text);
                        if (water.Checked == true) { comm.Parameters.AddWithValue("@water", 1); } else { comm.Parameters.AddWithValue("@water", 0); }
                        if (reaction.Checked == true) { comm.Parameters.AddWithValue("@react", 1); } else { comm.Parameters.AddWithValue("@react", 0); }
                        if (charger.Checked == true) { comm.Parameters.AddWithValue("@charg", 1); } else { comm.Parameters.AddWithValue("@charg", 0); }
                        if (scratches.Checked == true) { comm.Parameters.AddWithValue("@scrat", 1); } else { comm.Parameters.AddWithValue("@scrat", 0); }
                        comm.Parameters.AddWithValue("@problems", problems.Text);
                        comm.Parameters.AddWithValue("@contact", Convert.ToInt32(contact.Text));
                        comm.Parameters.AddWithValue("@cond", "В ожидании");
                        if (price.Text == "") { comm.Parameters.AddWithValue("@price", 0); }
                        else { comm.Parameters.AddWithValue("@price", Convert.ToInt32(price.Text)); }

                        comm.ExecuteNonQuery();
                        connection.Close();
                    }



                    SqlConnection cnn;
                    cnn = new SqlConnection(Properties.Settings.Default.conn);
                    cnn.Open();
                    string query = "SELECT Number FROM comenzi WHERE Name=@name AND Details=@det AND Price=@price";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@det", details.Text);
                    cmd.Parameters.AddWithValue("@price", price.Text);


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        num = Convert.ToString(reader["Number"]);
                    }
                    cnn.Close();



                    if (!name.Items.Contains(name.Text))
                    {

                        using (var connection = new SqlConnection(Properties.Settings.Default.conn))
                        {
                            connection.Open();
                            SqlCommand comm = connection.CreateCommand();
                            comm.CommandText = "INSERT INTO clients(Name, Contact) VALUES (@name,@contact)";
                            comm.Parameters.AddWithValue("@name", name.Text);
                            comm.Parameters.AddWithValue("@contact", Convert.ToInt32(contact.Text));

                            comm.ExecuteNonQuery();
                            connection.Close();
                        }
                    }

                    Comenzi comen = new Comenzi();
                    int imeei;
                    if (imei.Text == "") { imeei = 0; }
                    else
                    { imeei = Convert.ToInt32(imei.Text); }
                    comen.comenzidatagrid.DataSource = comen.getlist();
                    comen.comenzidatagrid.Sort(comen.comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                    string watr, reacti, bp, scr;
                    if (water.Checked == true) { watr = "Попадание влаги"; } else { watr = ""; }
                    if (reaction.Checked == true) { reacti = "Нет реакций"; } else { reacti = ""; }
                    if (charger.Checked == true) { bp = "Нет Б.П. (Ноутбук)"; } else { bp = ""; }
                    if (scratches.Checked == true) { scr = "Царапины"; } else { scr = ""; }
                    using (fstReceipt prt = new fstReceipt())
                    {
                        ReportParameter[] para = new ReportParameter[]
                        {
                new ReportParameter("FName", Properties.Settings.Default.NameOrg),
                new ReportParameter("FAdress", Properties.Settings.Default.AdressOrg),
                new ReportParameter("FPhone", Properties.Settings.Default.ContactOrg),
                new ReportParameter("FWork", Properties.Settings.Default.TimeOrg),
                new ReportParameter("FLogo", new Uri(Properties.Settings.Default.FileString).AbsoluteUri),
                new ReportParameter("Nr", num),
                new ReportParameter("Date", dataprimb.Text),
                new ReportParameter("Name", name.Text),
                new ReportParameter("Phone", contact.Text),
                new ReportParameter("Model", model.Text),
                new ReportParameter("IMEI", Convert.ToString(imeei)),
                new ReportParameter("Reception", "("+ receipt.Text +")"),
                new ReportParameter("Client", "("+ name.Text +")"),
                new ReportParameter("Service", details.Text),
                new ReportParameter("water", watr),
                new ReportParameter("react", reacti),
                new ReportParameter("charg", bp),
                new ReportParameter("scrat", scr),
                         };
                        prt.reportViewer1.LocalReport.EnableExternalImages = true;
                        prt.reportViewer1.LocalReport.SetParameters(para);
                        prt.ShowDialog();
                    }
                    Properties.Settings.Default.receptnow = receipt.Text;
                    Properties.Settings.Default.Save();
                    frm1.refreshgrid();
                    this.Hide();
                }
            }
        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            Comenzi com =   new Comenzi();
            com.refreshgrid();
        }
    }
}
