using System;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ServiceGSMApp
{
    public partial class Main : Form
    {
        public Main()
        {
            
            InitializeComponent();
            
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            try
            {
                cnn.Open();
                dbconnection.Text = "БД: Подключена";
                dbconnection.ForeColor = Color.Green;
                cnn.Close();
            }
            catch (Exception ex)
            {
                dbconnection.Text = "БД: Не Подключена";
                dbconnection.ForeColor = Color.Red;

            }
            cnn.Open();
            SqlCommand comm = cnn.CreateCommand();
            comm.CommandText = "USE MASTER; ALTER DATABASE Baza SET MULTI_USER";
            
            comm.ExecuteNonQuery();
            cnn.Close();

            
        }
        Point lastPoint;

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        
        

        private void dbconnection_Click(object sender, EventArgs e)
        {
            if (dbconnection.ForeColor == Color.Green)
            {
                if (Properties.Settings.Default.Administraton == "0")
                {
                    Properties.Settings.Default.Administraton = "1";
                    MessageBox.Show("Вы получили права Администратора!");
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Administraton = "0";
                    MessageBox.Show("Вы утратили права Администратора!");
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                MessageBox.Show("У вас не правельные параметры базы данных. Проверьте файл с настройками!");
            }
        }





        private void exit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Administraton = "0";
            Properties.Settings.Default.receptnow = "";
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit_txt.Visible = true;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit_txt.Visible = false;
        }

        private void orderspic_Click(object sender, EventArgs e)
        {
            if (dbconnection.ForeColor == Color.Green)
            {
                if (Properties.Settings.Default.FileString == "" || Properties.Settings.Default.NameOrg == "" || Properties.Settings.Default.AdressOrg == "" || Properties.Settings.Default.ContactOrg == "" || Properties.Settings.Default.TimeOrg == "" || Properties.Settings.Default.Diagnostic == "")
                {
                    MessageBox.Show("Заполните все данные в настройках!");
                }
                else
                {
                    Comenzi comenzi = null;
                    if (comenzi == null || comenzi.IsDisposed)
                    {
                        comenzi = new Comenzi();
                        comenzi.Show();
                    }
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Не возможно подключится к базе данных!");
            }
        }

        private void settingspic_Click(object sender, EventArgs e)
        {


            if (setting == null || setting.IsDisposed)
            {
                setting = new Settings();
                setting.Show();
            }
        }




        Settings setting;
        private void settings_Click_1(object sender, EventArgs e)
        {

            if (setting == null || setting.IsDisposed)
            {
                setting = new Settings();
                setting.Show();
            }
        }


        private void settingspics_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();
            setting.Show();
        }





        private void testings_Click(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.Administraton == "1")
            {
                int k = 0;
                do
                {
                    using (var connection = new SqlConnection(Properties.Settings.Default.conn))
                    {
                        connection.Open();

                        SqlCommand comm = connection.CreateCommand();

                        comm.CommandText = "INSERT INTO comenzi(DateReceipt, Receipt, Name, Model, IMEI, Details, Water, Reaction, Charger, Scratches, Problems, Contact, Condition, Price) VALUES (@date,@receipt,@name,@model,@imei,@details,@water,@react,@charg,@scrat,@problems,@contact,@cond,@price)";
                        //@date,@receipt,@number,@name,@model,@imei,@details,@water,@react,@charg,@scrat,@problems,@contact,@cond,@price

                        comm.Parameters.AddWithValue("@date", "2022-01-01 01:00:00");
                        comm.Parameters.AddWithValue("@receipt", "Sorin");
                        comm.Parameters.AddWithValue("@name", "Marin");
                        comm.Parameters.AddWithValue("@model", "Iphone XS");
                        comm.Parameters.AddWithValue("@imei", 1251);
                        comm.Parameters.AddWithValue("@details", "Ecran");
                        comm.Parameters.AddWithValue("@water", 1);
                        comm.Parameters.AddWithValue("@react", 1);
                        comm.Parameters.AddWithValue("@charg", 1);
                        comm.Parameters.AddWithValue("@scrat", 1);
                        comm.Parameters.AddWithValue("@problems", "");
                        comm.Parameters.AddWithValue("@contact", 804326321);
                        comm.Parameters.AddWithValue("@cond", "В ожидании");
                        comm.Parameters.AddWithValue("@price", 55);

                        comm.ExecuteNonQuery();
                        connection.Close();
                    }
                    //
                    k += 1;


                } while (k <= 10);
            }
            else
            {
                MessageBox.Show("У вас нет прав Администратора!");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {





            Properties.Settings.Default.receptnow = "";
            Properties.Settings.Default.Save();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Properties.Settings.Default.Administraton = "0";
                Properties.Settings.Default.receptnow = "";
                Properties.Settings.Default.Save();
                Application.Exit();

            }
        }

        private void orders_Click(object sender, EventArgs e)
        {

            if (dbconnection.ForeColor == Color.Green)
            {
                if (Properties.Settings.Default.FileString == "" || Properties.Settings.Default.NameOrg == "" || Properties.Settings.Default.AdressOrg == "" || Properties.Settings.Default.ContactOrg == "" || Properties.Settings.Default.TimeOrg == "" || Properties.Settings.Default.Diagnostic == "")
                {
                    MessageBox.Show("Заполните все данные в настройках!");
                }
                else
                {


                    Comenzi comenzi = null;
                    if (comenzi == null || comenzi.IsDisposed)
                    {
                        comenzi = new Comenzi();
                        comenzi.Show();
                    }
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Не возможно подключится к базе данных!");
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (setting == null || setting.IsDisposed)
            {
                setting = new Settings();
                setting.Show();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Administraton = "0";
            Properties.Settings.Default.receptnow = "";
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void dbselect_Click(object sender, EventArgs e)
        {
            

            try
            {
                OpenFileDialog folderBrowser = new OpenFileDialog();
                // Set validate names and check file exists to false otherwise windows will
                // not let you select "Folder Selection."
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                // Always default to Folder Selection.
                folderBrowser.FileName = "Folder Selection.";
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    test1.Text = Path.GetDirectoryName(folderBrowser.FileName);
                    //Properties.Settings.Default.conn = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security=True";
                    // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase.mdf;Integrated Security=True
                    //Data Source=.\SQLExpress;Initial Catalog=Baza;Persist Security Info=True;
                }

            }
            catch (Exception)
            {
                
                test1.Text = "Ошибка создания!";
            }



        }
    }
}
