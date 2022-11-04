using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace ServiceGSMApp
{
    public partial class doneform : Form
    {
        private readonly Comenzi frm1;
        public doneform(Comenzi frm)
        {
            
            InitializeComponent();
            diagnost = Int32.Parse(Properties.Settings.Default.Diagnostic);
            LoadModels();
            LoadMester();
            frm1 = frm;
        }
        
        int diagnost;
        

        public string nume;
        public string numar;


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

                            model.Items.Add(Convert.ToString(reader["Name"]));
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
            mester.SelectedIndex = 0;
        }


        
        private void price_TextChanged(object sender, EventArgs e)
        {
            if (diagn.Checked == true) { total.Text = Convert.ToString(Int32.Parse(price.Text) + diagnost); } else
            { total.Text = price.Text; }
        }

        private void diagn_CheckedChanged(object sender, EventArgs e)
        {
            if (diagn.Checked == true) { total.Text = Convert.ToString(Int32.Parse(price.Text) + diagnost); }
            else
            { total.Text = price.Text; }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            
             
            if (mester.Text == "" && model.Text == "" && details.Text == "" && totalt.Text == "" && price.Text == "")
            { MessageBox.Show("Зaполните все поля с знаком * "); }
            else
            {
                using (var connection = new SqlConnection(Properties.Settings.Default.conn))
                {
                    
                    
                    connection.Open();
                    SqlCommand comm = connection.CreateCommand();
                    comm.CommandText = "UPDATE comenzi SET DateFinish=@date, Master=@mester, Details=@details, Problems=@problems,Condition=@cond,Guarantee=@guarant, Price=@price WHERE Name=@name AND Model=@model AND Number=@number";
                    //@date,@receipt,@number,@name,@model,@imei,@details,@water,@react,@charg,@scrat,@problems,@contact,@cond,@price
                    
                    comm.Parameters.AddWithValue("@date", dataprimb.Value); //Convert.ToDateTime(dataprimb.Value)
                    comm.Parameters.AddWithValue("@mester", mester.Text);
                    comm.Parameters.AddWithValue("@details", details.Text);
                    comm.Parameters.AddWithValue("@problems", problems.Text);
                    if (guarantee.Checked == true) 
                    {
                        comm.Parameters.AddWithValue("@guarant", garantieb.Text);
                    } else
                    {
                        comm.Parameters.AddWithValue("@guarant", "0");
                    }
                    comm.Parameters.AddWithValue("@cond", "Готов");
                    comm.Parameters.AddWithValue("@price", Convert.ToInt32(total.Text));

                    comm.Parameters.AddWithValue("@name", nume);
                    comm.Parameters.AddWithValue("@number", Convert.ToInt32(numar));
                    comm.Parameters.AddWithValue("@model", model.Text);

                    comm.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();
                    comm.CommandText = "INSERT INTO doneorders SELECT * FROM  comenzi WHERE Number = @nr AND Name = @nume";
                    comm.Parameters.AddWithValue("@nr", Convert.ToInt32(numar));
                    comm.Parameters.AddWithValue("@nume", nume);
                    comm.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    comm.CommandText = "DELETE FROM comenzi WHERE Number = @nrr AND Name = @namee";
                    comm.Parameters.AddWithValue("@nrr", Convert.ToInt32(numar));
                    comm.Parameters.AddWithValue("@namee", nume);
                    comm.ExecuteNonQuery();
                    connection.Close();
                }

                Comenzi comen = new Comenzi();
                comen.conditionb.Text = "Готов";
                frm1.refreshgrid();
                this.Close();
            }
        }

        private void guarantee_CheckedChanged(object sender, EventArgs e)
        {
            if (guarantee.Checked == true)
            {
                garantie.Visible = true;
                garantieb.Visible = true;
            } else
            {
                garantieb.Visible = false;
                garantie.Visible = false;
            }
        }

        private void doneform_KeyDown(object sender, KeyEventArgs e)
        {
            
             
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (mester.Text == "" && model.Text == "" && details.Text == "" && totalt.Text == "" && price.Text == "")
                { MessageBox.Show("Зaполните все поля с знаком * "); }
                else
                {
                    using (var connection = new SqlConnection(Properties.Settings.Default.conn))
                    {


                        connection.Open();
                        SqlCommand comm = connection.CreateCommand();
                        comm.CommandText = "UPDATE comenzi SET DateFinish=@date, Master=@mester, Details=@details, Problems=@problems,Condition=@cond,Guarantee=@guarant, Price=@price WHERE Name=@name AND Model=@model AND Number=@number";
                        //@date,@receipt,@number,@name,@model,@imei,@details,@water,@react,@charg,@scrat,@problems,@contact,@cond,@price

                        comm.Parameters.AddWithValue("@date", dataprimb.Value); //Convert.ToDateTime(dataprimb.Value)
                        comm.Parameters.AddWithValue("@mester", mester.Text);
                        comm.Parameters.AddWithValue("@details", details.Text);
                        comm.Parameters.AddWithValue("@problems", problems.Text);
                        if (guarantee.Checked == true)
                        {
                            comm.Parameters.AddWithValue("@guarant", garantieb.Text);
                        }
                        else
                        {
                            comm.Parameters.AddWithValue("@guarant", "0");
                        }
                        comm.Parameters.AddWithValue("@cond", "Готов");
                        comm.Parameters.AddWithValue("@price", Convert.ToInt32(total.Text));

                        comm.Parameters.AddWithValue("@name", nume);
                        comm.Parameters.AddWithValue("@number", Convert.ToInt32(numar));
                        comm.Parameters.AddWithValue("@model", model.Text);

                        comm.ExecuteNonQuery();
                        connection.Close();

                        connection.Open();
                        comm.CommandText = "INSERT INTO doneorders SELECT * FROM  comenzi WHERE Number = @nr AND Name = @nume";
                        comm.Parameters.AddWithValue("@nr", Convert.ToInt32(numar));
                        comm.Parameters.AddWithValue("@nume", nume);
                        comm.ExecuteNonQuery();
                        connection.Close();
                        connection.Open();
                        comm.CommandText = "DELETE FROM comenzi WHERE Number = @nrr AND Name = @namee";
                        comm.Parameters.AddWithValue("@nrr", Convert.ToInt32(numar));
                        comm.Parameters.AddWithValue("@namee", nume);
                        comm.ExecuteNonQuery();
                        connection.Close();
                    }

                    Comenzi comen = new Comenzi();
                    comen.conditionb.Text = "Готов";
                    frm1.refreshgrid();
                    this.Close();
                }
            }
        }
    }
}
