using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceGSMApp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            settingsload();
        }
        
        int tabel;
        bool admin;


        
        string fileLocation;

        public void settingsload()
        {
            
            if (Properties.Settings.Default.Administraton == "1") { admin = true; administrator.Text = "У вас права Администратора!"; } else { admin = false; administrator.Text = "У вас нету прав Администратора!"; }
            if (admin == true)
            {
                label10.Visible = true;
                clearwait.Visible = true;
                backup.Visible = true;
                restore.Visible = true;
            } 
        }
        string floc;
        private void close_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NameOrg = orgname.Text;
            Properties.Settings.Default.AdressOrg = orgadress.Text;
            Properties.Settings.Default.ContactOrg = orgphone.Text;
            Properties.Settings.Default.TimeOrg = orgtime.Text;
            Properties.Settings.Default.Diagnostic = diagnosticsprice.Text;
            Properties.Settings.Default.Save();

            this.Hide();
        }
        public void masrec_load()
        {
            
             
            using (var connection = new SqlConnection(Properties.Settings.Default.conn))
            {
                connection.Open();
                var query = "SELECT Name,Nr FROM reception";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            nrr.Items.Add(Convert.ToInt32(reader["Nr"]));
                            receptionlist.Items.Add(Convert.ToString(reader["Name"]));
                        }
                    }
                }
                query = "SELECT Name,Nr FROM masters";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            nrm.Items.Add(Convert.ToInt32(reader["Nr"]));
                            masterlist.Items.Add(Convert.ToString(reader["Name"]));
                        }
                    }
                }

            }
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            fileLocation = Properties.Settings.Default.FileString;
            
                if (fileLocation != "")
                {
                    try
                    {
                        Image image = Image.FromFile(Properties.Settings.Default.FileString);
                        this.logobox.Image = image;
                    } finally
                    {
                        Image image = Image.FromFile(Directory.GetCurrentDirectory()+ "\\lib\\image.jpg");
                        this.logobox.Image = image;
                    }
                    
                }
            
            orgname.Text = Properties.Settings.Default.NameOrg;
            orgadress.Text = Properties.Settings.Default.AdressOrg;
            orgphone.Text = Properties.Settings.Default.ContactOrg;
            orgtime.Text = Properties.Settings.Default.TimeOrg;
            diagnosticsprice.Text = Properties.Settings.Default.Diagnostic;


            
             
            using (var connection = new SqlConnection(Properties.Settings.Default.conn))
            {
                connection.Open();
                var query = "SELECT Name,Nr FROM reception";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            nrr.Items.Add(Convert.ToInt32(reader["Nr"]));
                            receptionlist.Items.Add(Convert.ToString(reader["Name"]));
                        }
                    }
                }
                query = "SELECT Name,Nr FROM masters";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            nrm.Items.Add(Convert.ToInt32(reader["Nr"]));
                            masterlist.Items.Add(Convert.ToString(reader["Name"]));
                        }
                    }
                }

            }

        }

        private void masterlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (receptionlist.Items.Count > 0) { receptionlist.ClearSelected(); }
            if (masterlist.SelectedItems.Count > 0)
            {
                receptionlist.ClearSelected();
                nrr.ClearSelected();
                nrr.SelectedIndex = receptionlist.SelectedIndex;
                tabel = 0;
            }
        }

        private void receptionlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (masterlist.Items.Count > 0) { masterlist.ClearSelected(); }
            if (receptionlist.SelectedItems.Count > 0) {
                masterlist.ClearSelected();
                nrm.ClearSelected();
                nrm.SelectedIndex = masterlist.SelectedIndex;
                tabel = 1;
            }
            
            
        }

        private void remove_Click(object sender, EventArgs e)
        {
            
             
            if (masterlist.Items.Count > 0 || receptionlist.Items.Count > 0)
            {
                SqlConnection cnn;
                cnn = new SqlConnection(Properties.Settings.Default.conn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                string querry = "";
                if (tabel == 0) { querry = "DELETE FROM masters WHERE Nr = @id AND Name = @nume"; }
                if (tabel == 1) { querry = "DELETE FROM reception WHERE Nr = @id AND Name = @nume"; }
                cmd.CommandText = querry;
                if (tabel == 0)
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(nrm.Items[masterlist.SelectedIndex].ToString()));
                    cmd.Parameters.AddWithValue("@nume", masterlist.SelectedValue.ToString());
                }
                if (tabel == 1)
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(nrr.Items[receptionlist.SelectedIndex].ToString()));
                    cmd.Parameters.AddWithValue("@nume", receptionlist.SelectedItem.ToString());
                }
                cmd.ExecuteNonQuery();
                cnn.Close();
                int index;
                if (tabel == 0) { index = masterlist.SelectedIndex; masterlist.Items.RemoveAt(index); nrm.Items.RemoveAt(index); }
                if (tabel == 1) { index = receptionlist.SelectedIndex; receptionlist.Items.RemoveAt(index); nrr.Items.RemoveAt(index); }

                

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

        private void addm_Click(object sender, EventArgs e)
        {
            
             
            if (name.Text.Length > 0 && contact.Text.Length > 0)
            {
                SqlConnection cnn;
                cnn = new SqlConnection(Properties.Settings.Default.conn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                string querry = "INSERT INTO masters(Name, Contact) VALUES (@nume,@contact)";
                cmd.CommandText = querry;
                
                cmd.Parameters.AddWithValue("@contact", Convert.ToInt32(contact.Text));
                cmd.Parameters.AddWithValue("@nume", name.Text);
                
                cmd.ExecuteNonQuery();
                cnn.Close();
                
                masterlist.Items.Clear();
                receptionlist.Items.Clear();
                nrr.Items.Clear();
                nrm.Items.Clear();
                masrec_load();
                name.Text = "";
                contact.Text = "";
            }
            else
            {
                MessageBox.Show("Заполните поле Имя и Телефон!");
            }
        }

        private void addr_Click(object sender, EventArgs e)
        {
           
             
            if (name.Text.Length > 0 && contact.Text.Length > 0)
            {
                SqlConnection cnn;
                cnn = new SqlConnection(Properties.Settings.Default.conn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                string querry = "INSERT INTO reception(Name, Contact) VALUES (@nume,@contact)";
                cmd.CommandText = querry;

                cmd.Parameters.AddWithValue("@contact", Convert.ToInt32(contact.Text));
                cmd.Parameters.AddWithValue("@nume", name.Text);

                cmd.ExecuteNonQuery();
                cnn.Close();

                masterlist.Items.Clear();
                receptionlist.Items.Clear();
                nrr.Items.Clear();
                nrm.Items.Clear();
                masrec_load();
                name.Text = "";
                contact.Text = "";
            }
            else
            {
                MessageBox.Show("Заполните поле Имя и Телефон!");
            }
        }

        
        private void upload_Click(object sender, EventArgs e)
        {

            string fileLocation = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Browse Image File";
            fdlg.Filter = "Image Files (*.BMP:*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fileLocation = fdlg.FileName;
            }
            floc = fileLocation;
            pathimg.path = fileLocation;
            if (pathimg.path != "")
            {
                Properties.Settings.Default.FileString = pathimg.path;
                Properties.Settings.Default.Save();
            }

            Image image = Image.FromFile(Properties.Settings.Default.FileString);
            this.logobox.Image = image;

        }

        private void orgphone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(orgphone.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалйсто вводите только цифры.");
                orgphone.Text = orgphone.Text.Remove(orgphone.Text.Length - 1);
            }
        }

        private void deleteimg_Click(object sender, EventArgs e)
        {
            if (pathimg.path != "")
            {
                Properties.Settings.Default.FileString = "";
                Properties.Settings.Default.Save();
            }
            this.logobox.Image = null;
        }

        private void clearwait_Click(object sender, EventArgs e)
        {
            
             
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            string querry = "DELETE FROM comenzi";
            cmd.CommandText = querry;
            cmd.ExecuteNonQuery();
            cnn.Close();
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            cmd.Connection = cnn;
            querry = "DELETE FROM doneorders";
            cmd.CommandText = querry;
            cmd.ExecuteNonQuery();
            cnn.Close();
            cnn.Open();
            cmd.Connection = cnn;
            querry = "DBCC CHECKIDENT ('comenzi', RESEED , 0);";
            cmd.CommandText = querry;
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        // 216, 11
        private void cleardone_Click(object sender, EventArgs e)
        {
            
             
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            string querry = "DELETE FROM doneorders";
            cmd.CommandText = querry;
            cmd.ExecuteNonQuery();
            cnn.Close();

            
        }

        private void modlist_Click(object sender, EventArgs e)
        {
            models model = new models();
            model.Show();
            
        }

        private void clnlist_Click(object sender, EventArgs e)
        {
            clients client = new clients();
            client.Show();
        }


        private void gen_Click(object sender, EventArgs e)
        {
            gen.Font = new Font(gen.Font.Name, gen.Font.SizeInPoints, FontStyle.Bold | FontStyle.Underline);
            masterbtn.Font = new Font(masterbtn.Font.Name, masterbtn.Font.SizeInPoints, FontStyle.Bold);
            statbtn.Font = new Font(statbtn.Font.Name, statbtn.Font.SizeInPoints, FontStyle.Bold);
            databtn.Font = new Font(databtn.Font.Name, databtn.Font.SizeInPoints, FontStyle.Bold);
            listworkers.Visible = false;
            organisation.Visible = false;
            generalpanel.Visible = true;
            statpanel.Visible = false;
        }

        private void masterbtn_Click(object sender, EventArgs e)
        {
            masterbtn.Font = new Font(masterbtn.Font.Name, masterbtn.Font.SizeInPoints, FontStyle.Bold | FontStyle.Underline);
            gen.Font = new Font(gen.Font.Name, gen.Font.SizeInPoints, FontStyle.Bold);
            statbtn.Font = new Font(statbtn.Font.Name, statbtn.Font.SizeInPoints, FontStyle.Bold);
            databtn.Font = new Font(databtn.Font.Name, databtn.Font.SizeInPoints, FontStyle.Bold);
            listworkers.Visible = true;
            organisation.Visible = false;
            generalpanel.Visible = false;
            statpanel.Visible = false;
        }

        private void databtn_Click(object sender, EventArgs e)
        {
            databtn.Font = new Font(databtn.Font.Name, databtn.Font.SizeInPoints, FontStyle.Bold | FontStyle.Underline);
            masterbtn.Font = new Font(masterbtn.Font.Name, masterbtn.Font.SizeInPoints, FontStyle.Bold);
            statbtn.Font = new Font(statbtn.Font.Name, statbtn.Font.SizeInPoints, FontStyle.Bold);
            gen.Font = new Font(gen.Font.Name, gen.Font.SizeInPoints, FontStyle.Bold);
            listworkers.Visible = false;
            organisation.Visible = true;
            generalpanel.Visible = false;
            statpanel.Visible = false;
        }

        private void statbtn_Click(object sender, EventArgs e)
        {
            statbtn.Font = new Font(statbtn.Font.Name, statbtn.Font.SizeInPoints, FontStyle.Bold | FontStyle.Underline);
            masterbtn.Font = new Font(masterbtn.Font.Name, masterbtn.Font.SizeInPoints, FontStyle.Bold);
            databtn.Font = new Font(databtn.Font.Name, databtn.Font.SizeInPoints, FontStyle.Bold);
            gen.Font = new Font(gen.Font.Name, gen.Font.SizeInPoints, FontStyle.Bold);
            listworkers.Visible = false;
            organisation.Visible = false;
            generalpanel.Visible = false;
            statpanel.Visible = true;
            statistics();
        }



        private void statistics()
        {
            
             
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            string querry = "SELECT COUNT(*) FROM comenzi";
            SqlCommand cmd = new SqlCommand(querry, cnn);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            
            if (result != 0)
            {
                cnn = new SqlConnection(Properties.Settings.Default.conn);
                cnn.Open();
                querry = "SELECT COUNT(Number) FROM comenzi WHERE Condition=@ojid";
                cmd = new SqlCommand(querry, cnn);

                cmd.Parameters.AddWithValue("@ojid", "В ожидании");
                try { nrstat.Text = Convert.ToString(cmd.ExecuteScalar()); } catch { }
                

                
                querry = "SELECT COUNT(Number) FROM comenzi WHERE Condition=@reject";
                cmd.CommandText = querry;
                cmd.Parameters.AddWithValue("@reject", "Отказ");
                try { nrreject.Text = Convert.ToString(cmd.ExecuteScalar()); } catch {}
                

                
                querry = "SELECT COUNT(Number) FROM doneorders WHERE Condition=@done";
                cmd.CommandText = querry;
                cmd.Parameters.AddWithValue("@done", "Готов");
                try {nrdone.Text = Convert.ToString(cmd.ExecuteScalar()); } catch { }
                

                
                querry = "SELECT COUNT(Number) FROM doneorders WHERE Condition=@issue";
                cmd.CommandText = querry;
                cmd.Parameters.AddWithValue("@issue", "Выдан");
                try {nrissue.Text = Convert.ToString(cmd.ExecuteScalar()); } catch { }
                

                
                querry = "SELECT COUNT(Number) FROM comenzi";
                cmd.CommandText = querry;
                int comen = 0;
                int donecomen = 0;
                try {comen = Convert.ToInt32(cmd.ExecuteScalar()); } catch { }
                querry = "SELECT COUNT(Number) FROM doneorders";
                cmd.CommandText = querry;
                try{ donecomen = Convert.ToInt32(cmd.ExecuteScalar());} catch { }
                nrtotal.Text = Convert.ToString(comen + donecomen);
                
                

                
                querry = "SELECT SUM(Price) FROM comenzi";
                cmd.CommandText = querry;
                try {monwait.Text = Convert.ToString(cmd.ExecuteScalar()); } catch { }
                if (monwait.Text == "") { monwait.Text = "0"; }
                
                
                querry = "SELECT SUM(Price) FROM doneorders";
                cmd.CommandText = querry;
                try {monget.Text = Convert.ToString(cmd.ExecuteScalar()); } catch { }
                if (monget.Text == "") { monget.Text = "0"; }
                
                int monen = Convert.ToInt32(monwait.Text);
                int donemon = Convert.ToInt32(monget.Text);
                
                montotal.Text = Convert.ToString(monen + donemon);
                
            } else
            {
                nrstat.Text = "0";
                nrreject.Text = "0";
                nrdone.Text = "0";
                nrissue.Text = "0";
                nrtotal.Text = "0";
                monwait.Text = "0";
                monget.Text = "0";
                montotal.Text = "0";
            }
            cnn.Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.NameOrg = orgname.Text;
            Properties.Settings.Default.AdressOrg = orgadress.Text;
            Properties.Settings.Default.ContactOrg = orgphone.Text;
            Properties.Settings.Default.TimeOrg = orgtime.Text;
            Properties.Settings.Default.Diagnostic = diagnosticsprice.Text;
            Properties.Settings.Default.Save();
            
        }

        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Properties.Settings.Default.NameOrg = orgname.Text;
                Properties.Settings.Default.AdressOrg = orgadress.Text;
                Properties.Settings.Default.ContactOrg = orgphone.Text;
                Properties.Settings.Default.TimeOrg = orgtime.Text;
                Properties.Settings.Default.Diagnostic = diagnosticsprice.Text;
                Properties.Settings.Default.Save();
                this.Close();

                // prevent child controls from handling this event as well
                e.SuppressKeyPress = true;
            }
        }

        private void backup_Click(object sender, EventArgs e)
        {
            /*string folder = "";

            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folder = diag.SelectedPath;  //selected folder path
                MessageBox.Show(folder);
            }

            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            string querry = "BACKUP DATABASE DataBase.mdf TO DISK = @folder GO";
            cmd.Parameters.AddWithValue("@folder", folder+"DataBase.BAK");
            cmd.CommandText = querry;
            cmd.ExecuteNonQuery();
            cnn.Close();*/
           
             
            SqlConnection con;
            con = new SqlConnection(Properties.Settings.Default.conn);
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "SQL Server database backup files|*.bak";
                sd.Title = "Create Database Backup";

                if (sd.ShowDialog() == DialogResult.OK)
                {

                    string sqlStmt = string.Format("backup database Baza to disk='{0}'", sd.FileName);
                    using (SqlCommand bu2 = new SqlCommand(sqlStmt, con))
                    {
                        con.Open();
                        bu2.ExecuteNonQuery();
                        con.Close();
                        bktext.Visible = true;
                        bktext.Text = "Резервная копия создана!";

                    }
                }
            }
            catch (Exception)
            {
                bktext.Visible = true;
                bktext.Text = "Ошибка создания!";
            }



        }

        private void restore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Backup sql",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "bak",
                Filter = "backup files (*.bak)|*.bak",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            
             
            SqlConnection con;
            con = new SqlConnection(Properties.Settings.Default.conn);
            con.Open();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string sqlStmt = "USE master; ALTER DATABASE Baza SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    using (SqlCommand bu = new SqlCommand(sqlStmt, con))

                    {
                        bu.Connection = con;
                        //bu2.CommandText = sqlStmt;

                        bu.ExecuteNonQuery();
                    }
                   
                     
                     sqlStmt = string.Format("USE master; RESTORE DATABASE Baza from disk='{0}'", openFileDialog1.FileName);
                    using (SqlCommand bu2 = new SqlCommand(sqlStmt, con))

                    {
                        bu2.Connection = con;
                        //bu2.CommandText = sqlStmt;

                        bu2.ExecuteNonQuery();
                    }
                    sqlStmt = "USE master; ALTER DATABASE Baza SET MULTI_USER;";
                    using (SqlCommand bu3 = new SqlCommand(sqlStmt, con))

                    {
                        bu3.Connection = con;
                        //bu2.CommandText = sqlStmt;

                        bu3.ExecuteNonQuery();
                    }
                    con.Close();
                    bktext.Visible = true;
                    bktext.Text = "Копия загружена успешно!";
                }
                catch (Exception ex)
                {
                    bktext.Visible = true;
                    bktext.Text = "Ошибка загрузки!";
                    MessageBox.Show(ex.ToString());
                }
                con.Close();
            }
        }
    }
}
