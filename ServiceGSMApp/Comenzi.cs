using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ServiceGSMApp
{
    public partial class Comenzi : Form
    {
        public Comenzi()
        {

            if (Properties.Settings.Default.Administraton == "1") { admin = true; } else { admin = false; }
            InitializeComponent();
        }
        
        int garant;
        bool admin = false;


        private void closebtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Main main = new Main();
            main.Show();
        }



        private void Comenzi_Load(object sender, EventArgs e)
        {
            comenzidatagrid.DataSource = getlist();
            comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
        }
        DataTable dt = new DataTable();
        public DataTable getlist()
        {
            
             
            DataTable dt = new DataTable();
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            SqlCommand cmd = new SqlCommand("SELECT DateReceipt,Number,Name,Model,Contact,Condition FROM comenzi", cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            return dt;

        }
        public DataTable getlistgata()
        {
            
             
            DataTable dt = new DataTable();
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);

            SqlCommand cmd = new SqlCommand("SELECT DateReceipt,Number,Name,Model,Contact,Condition FROM doneorders", cnn);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        private void finish_Click(object sender, EventArgs e)
        {

            if (finish.ForeColor == Color.Black)
            {
                comenzidatagrid.DataSource = getlistgata();
                comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                finish.ForeColor = Color.Red;

                actual.ForeColor = Color.Black;

                panel1.Visible = true;
                reject.Enabled = false;
            }

        }


        private void numarsort_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = comenzidatagrid.DataSource;

            if (numarsort.Text.Length == 0)
            {
                bs.Filter = String.Empty;
            }
            else
            {
                bs.Filter = String.Format("CONVERT([Number], System.String) LIKE '%{0}%'", numarsort.Text); 
            }

            comenzidatagrid.Refresh();



        }

        private void numesort_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = comenzidatagrid.DataSource;
            if (numesort.Text.Length == 0)
            {
                bs.Filter = String.Empty;
            }
            else
            {
                bs.Filter = String.Format("[Name] LIKE '%{0}%'", numesort.Text);
            }

            comenzidatagrid.Refresh();



        }
        int index;
        private void comenzidatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
             
            index = e.RowIndex;
            if (index >= 0)
            {

                DataGridViewRow selectedRow = comenzidatagrid.Rows[index];
                comenzidatagrid.Rows[index].Selected = true;

                int ap;
                int lucr;
                int cg;
                int scr;

                string tempnr = selectedRow.Cells[1].Value.ToString();
                string tempnum = selectedRow.Cells[2].Value.ToString();
                if (tempnr.Length == 0 || tempnum.Length == 0) { return; }
                else
                {
                    next.Enabled = true;
                    back.Enabled = true;
                    numarb.Text = tempnr;
                    numeb.Text = tempnum;

                    SqlConnection cnn;
                    cnn = new SqlConnection(Properties.Settings.Default.conn);
                    cnn.Open();
                    string query;
                    if (finish.ForeColor == Color.Red) { query = "SELECT * FROM doneorders WHERE Number = @nr AND Name = @nume"; }
                    else { query = "SELECT * FROM comenzi WHERE Number = @nr AND Name = @nume"; }
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@nr", Convert.ToInt32(tempnr));
                    cmd.Parameters.AddWithValue("@nume", Convert.ToString(tempnum));

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        mesterlist.Text = String.Format("{0}", reader["Master"]);
                        contactb.Text = String.Format("{0}", reader["Contact"]);
                        imeib.Text = String.Format("{0}", reader["IMEI"]);
                        if (imeib.Text == "0") imeib.Text = "";
                        telefonb.Text = String.Format("{0}", reader["Model"]);
                        conditionb.Text = String.Format("{0}", reader["Condition"]);
                        receptb.Text = String.Format("{0}", reader["Receipt"]);
                        detailsb.Text = String.Format("{0}", reader["Details"]);
                        problemsb.Text = String.Format("{0}", reader["Problems"]);
                        ap = Convert.ToInt32(reader["Water"]);
                        if (ap == 1) water.Checked = true; else water.Checked = false;
                        lucr = Convert.ToInt32(reader["Reaction"]);
                        if (lucr == 1) reaction.Checked = true; else reaction.Checked = false;
                        cg = Convert.ToInt32(reader["Charger"]);
                        if (cg == 1) charger.Checked = true; else charger.Checked = false;
                        scr = Convert.ToInt32(reader["Scratches"]);
                        if (scr == 1) scratches.Checked = true; else scratches.Checked = false;
                        dataprimb.Value = Convert.ToDateTime(reader["DateReceipt"]);

                        if (conditionb.Text == "В ожидании")
                        {
                            datafin.Visible = false;
                            datafinb.Visible = false;
                            datapred.Visible = false;
                            dataredb.Visible = false;
                            garantieb.Visible = false;
                            grnt.Visible = false;
                            garantie.Visible = false;
                        }
                        if (conditionb.Text == "Отказ")
                        {
                            garantieb.Text = "";
                            datafin.Visible = false;
                            datafinb.Visible = false;
                            datapred.Visible = false;
                            dataredb.Visible = false;
                            garantieb.Visible = false;
                            grnt.Visible = false;
                            garantie.Visible = false;
                        }
                        if (conditionb.Text == "Готов")
                        {
                            datafinb.Value = Convert.ToDateTime(reader["DateFinish"]);
                            garantieb.Text = "";
                            datafin.Visible = true;
                            datafinb.Visible = true;
                            datapred.Visible = false;
                            dataredb.Visible = false;
                            garantieb.Visible = false;
                            grnt.Visible = false;
                            garantie.Visible = false;
                        }
                        if (conditionb.Text == "Выдан")
                        {
                            datafinb.Value = Convert.ToDateTime(reader["DateFinish"]);
                            dataredb.Value = Convert.ToDateTime(reader["DateIssue"]);
                            garantieb.Text = String.Format("{0}", reader["Guarantee"]);
                            garant = Convert.ToInt32(garantieb.Text);
                            datafin.Visible = true;
                            datafinb.Visible = true;
                            datapred.Visible = true;
                            dataredb.Visible = true;
                            garantieb.Visible = true;
                            grnt.Visible = true;
                            garantie.Visible = true;
                        }
                        if (conditionb.Text == "Выдан")
                        {
                            grnt.Visible = true;
                            if ((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days < 0) { grnt.ForeColor = Color.Red; grnt.Text = Convert.ToString(((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days) * (-1)); }
                            else
                          if ((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days == 0) { grnt.ForeColor = Color.Orange; grnt.Text = Convert.ToString((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days); }
                            else
                         if ((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days > 0) { grnt.ForeColor = Color.Green; grnt.Text = Convert.ToString((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days); }
                        }
                        else
                        {
                            grnt.Visible = false;
                        }

                        priceb.Text = Convert.ToString(reader["Price"]);
                    }
                    cnn.Close();

                    switch (conditionb.Text)
                    {
                        case "Отказ":
                            { next.Text = "Завершить Ремонт"; next.Enabled = true; back.Text = "Вернуть в Ожидании"; back.Enabled = true; reject.Enabled = false; editbtn.Enabled = false; }
                            break;
                        case "В ожидании":
                            { next.Text = "Завершить Ремонт"; next.Enabled = true; back.Text = "Вернуть в Ожидании"; back.Enabled = false; reject.Enabled = true; editbtn.Enabled = true; }
                            break;
                        case "Готов":
                            { next.Text = "Выдать"; next.Enabled = true; back.Text = "Вернуть в Ремонт"; back.Enabled = true; reject.Enabled = false; editbtn.Enabled = true; }
                            break;
                        default:
                            { next.Text = "Напечатать Документ"; next.Enabled = true; back.Text = "Вернуть в Готовые"; back.Enabled = true; reject.Enabled = false; editbtn.Enabled = false; }
                            break;
                    }

                }
            }


        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Add add = new Add(this);
            add.Show();

        }

        private void actual_Click(object sender, EventArgs e)
        {

            if (actual.ForeColor == Color.Black)
            {
                comenzidatagrid.DataSource = getlist();
                comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                actual.ForeColor = Color.Red;

                finish.ForeColor = Color.Black;
                reject.Enabled = true;


            }

            //}
        }

        private void imeib_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(imeib.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалйсто вводите только цифры.");
                imeib.Text = imeib.Text.Remove(imeib.Text.Length - 1);
            }
        }
        public void refreshgrid()
        {
            if (finish.ForeColor == Color.Red)
            {
                string numcom = numarb.Text;
                comenzidatagrid.DataSource = getlistgata();
                comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                int numrow = comenzidatagrid.Rows.Count;
                comenzidatagrid.ClearSelection();
                for (int i = 0; i < numrow; i++)
                {
                    if (comenzidatagrid.Rows[i].Cells[1].Value.ToString() == numcom) { comenzidatagrid.Rows[i].Selected = true; }
                }
            }
            else
            {
                string numcom = numarb.Text;
                comenzidatagrid.DataSource = getlist();
                comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                int numrow = comenzidatagrid.Rows.Count;
                comenzidatagrid.ClearSelection();
                for (int i = 0; i < numrow; i++)
                {
                    if (comenzidatagrid.Rows[i].Cells[1].Value.ToString() == numcom) { comenzidatagrid.Rows[i].Selected = true; }
                }
            }
        }


        public void bfinish()
        {
            
             
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "UPDATE doneorders SET Condition=@cond, Master=@mester,Details=@details, Problems=@problems,Guarantee=@guarant WHERE Number = @numar AND Name = @numee";
            cmd.Parameters.AddWithValue("@numar", Convert.ToInt32(numarb.Text));
            cmd.Parameters.AddWithValue("@numee", Convert.ToString(numeb.Text));
            cmd.Parameters.AddWithValue("@cond", "В ожидании");

            cmd.Parameters.AddWithValue("@mester", "");
            cmd.Parameters.AddWithValue("@details", "");
            cmd.Parameters.AddWithValue("@problems", "");
            cmd.Parameters.AddWithValue("@guarant", "");
            cmd.ExecuteNonQuery();
            cnn.Close();
            cnn.Open();
            cmd.CommandText = "SET IDENTITY_INSERT comenzi ON";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SET IDENTITY_INSERT dbo.comenzi ON; INSERT INTO comenzi(DateReceipt, DateFinish, DateIssue, Receipt, Master, Number, Name, Model, IMEI, Details, Water, Reaction, Charger, Scratches, Problems, Contact, Condition, Guarantee, Price) SELECT DateReceipt, DateFinish, DateIssue, Receipt, Master, Number, Name, Model, IMEI, Details, Water, Reaction, Charger, Scratches, Problems, Contact, Condition, Guarantee, Price FROM  doneorders WHERE Number = @nrr AND Name = @name";
            cmd.Parameters.AddWithValue("@nrr", Convert.ToInt32(numarb.Text));
            cmd.Parameters.AddWithValue("@name", Convert.ToString(numeb.Text));
            cmd.ExecuteNonQuery();
            cnn.Close();
            cnn.Open();
            cmd.CommandText = "DELETE FROM doneorders WHERE Number = @nr AND Name = @nume";
            cmd.Parameters.AddWithValue("@nr", Convert.ToInt32(numarb.Text));
            cmd.Parameters.AddWithValue("@nume", Convert.ToString(numeb.Text));
            cmd.ExecuteNonQuery();
            cnn.Close();
            conditionb.Text = "В ожидании";
        }


        public void bissue()
        {
            
             
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "UPDATE doneorders SET Condition=@cond  WHERE Number = @numar AND Name = @numee";
            cmd.Parameters.AddWithValue("@numar", Convert.ToInt32(numarb.Text));
            cmd.Parameters.AddWithValue("@numee", Convert.ToString(numeb.Text));
            cmd.Parameters.AddWithValue("@cond", "Готов");

            cmd.ExecuteNonQuery();
            cnn.Close();
        }




        private void next_Click(object sender, EventArgs e)
        {

            if (comenzidatagrid.SelectedCells.Count > 0)
            {
                if (numarb.Text == "" || numeb.Text == "") { return; }
                else
                {
                    switch (conditionb.Text)
                    {
                        case "В ожидании":
                            {
                                doneform don = new doneform(this);
                                don.nume = numeb.Text;
                                don.numar = numarb.Text;
                                don.model.Text = telefonb.Text;
                                don.problems.Text = problemsb.Text;
                                don.details.Text = detailsb.Text;
                                don.price.Text = priceb.Text;
                                don.Show();
                                btns();
                                refreshgrid();
                            };
                            break;
                        case "Отказ":
                            {
                                doneform don = new doneform(this);
                                don.Show();
                                don.nume = numeb.Text;
                                don.numar = numarb.Text;
                                don.model.Text = telefonb.Text;
                                btns();
                                refreshgrid();
                            };
                            break;
                        case "Готов":
                            {
                                dateTime.Visible = true;
                                addtime.Visible = true;
                                datepanel.Visible = true;
                                comenzidatagrid.Enabled = false;
                                btns();
                                refreshgrid();
                                next.Enabled = false;
                                back.Enabled = false;
                                reject.Enabled = false;
                                delete.Enabled = false;
                                addbtn.Enabled = false;
                            }
                            break;
                        case "Выдан":
                            {
                                using (PrintReceipt prt = new PrintReceipt())
                                {


                                    ReportParameter[] para = new ReportParameter[]
                                    {
                                    new ReportParameter("FName",Properties.Settings.Default.NameOrg),
                                    new ReportParameter("FAdress",Properties.Settings.Default.AdressOrg),
                                    new ReportParameter("FPhone",Properties.Settings.Default.ContactOrg),
                                    new ReportParameter("FWork",Properties.Settings.Default.TimeOrg),
                                    new ReportParameter("FLogo", new Uri(Properties.Settings.Default.FileString).AbsoluteUri),
                                    new ReportParameter("FNr",numarb.Text),
                                    new ReportParameter("Reception","("+receptb.Text+")"),
                                    new ReportParameter("Client","("+numeb.Text+")"),
                                    new ReportParameter("Data",dataredb.Text),
                                    new ReportParameter("Name",numeb.Text),
                                    new ReportParameter("Phone",contactb.Text),
                                    new ReportParameter("Model",telefonb.Text),
                                    new ReportParameter("IMEI",imeib.Text),
                                    new ReportParameter("Service", detailsb.Text),
                                    new ReportParameter("Price",priceb.Text),
                                    };
                                    prt.reportViewer1.LocalReport.EnableExternalImages = true;
                                    prt.reportViewer1.LocalReport.SetParameters(para);
                                    prt.ShowDialog();
                                }

                            }
                            break;

                    }


                }
            }




        }

        private void back_Click(object sender, EventArgs e)
        {
            if (comenzidatagrid.SelectedCells.Count > 0)
            {
                switch (conditionb.Text)
                {

                    case "Отказ":
                        {

                            breject();
                            conditionb.Text = "В ожидании";
                            btns();
                            if (comenzidatagrid.SelectedCells.Count == 0)
                            {
                                comenzidatagrid.SelectedCells[0].Selected = true;
                            }
                            refreshgrid();
                            comenzidatagrid.DataSource = getlist();
                            comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                        }
                        break;
                    case "Готов":
                        {

                            bfinish();
                            conditionb.Text = "В ожидании";
                            btns();
                            if (comenzidatagrid.SelectedCells.Count == 0)
                            {
                                comenzidatagrid.SelectedCells[0].Selected = true;
                            }
                            refreshgrid();
                            comenzidatagrid.DataSource = getlistgata();
                            comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                        }
                        break;
                    case "Выдан":
                        {
                            bissue();
                            conditionb.Text = "Готов";
                            btns();
                            if (comenzidatagrid.SelectedCells.Count == 0)
                            {
                                comenzidatagrid.SelectedCells[0].Selected = true;
                            }
                            refreshgrid();
                            comenzidatagrid.DataSource = getlistgata();
                            comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                        }
                        break;

                }
            }
        }

        private void btns()
        {
            switch (conditionb.Text)
            {
                case "Отказ":
                    { next.Text = "Завершить Ремонт"; next.Enabled = true; back.Text = "Вернуть в Ожидании"; back.Enabled = true; reject.Enabled = false; editbtn.Enabled = false; }
                    break;
                case "В ожидании":
                    { next.Text = "Завершить Ремонт"; next.Enabled = true; back.Text = "Вернуть в Ожидании"; back.Enabled = false; reject.Enabled = true; editbtn.Enabled = true; }
                    break;
                case "Готов":
                    { next.Text = "Выдать"; next.Enabled = true; back.Text = "Вернуть в Ожидании"; back.Enabled = true; reject.Enabled = false; editbtn.Enabled = true; }
                    break;
                default:
                    { next.Text = "Напечатать Документ"; next.Enabled = true; back.Text = "Вернуть в Готовые"; back.Enabled = true; reject.Enabled = false; editbtn.Enabled = false; dataredb.Visible = true; datapred.Visible = true; grnt.Visible = true; garantie.Visible = true; garantieb.Visible = true; }
                    break;
            }
        }

        private void conditionb_TextChanged(object sender, EventArgs e)
        {
            btns();
        }
        private void breject()
        {
            
             
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "UPDATE comenzi SET Condition=@cond WHERE Number = @nr AND Name = @nume";
            cmd.Parameters.AddWithValue("@nr", Convert.ToInt32(numarb.Text));
            cmd.Parameters.AddWithValue("@nume", Convert.ToString(numeb.Text));
            cmd.Parameters.AddWithValue("@cond", "В ожидании");
            cmd.ExecuteNonQuery();
            cnn.Close();
            conditionb.Text = "В ожидании";
            btns();
            refreshgrid();
        }
        private void reject_Click(object sender, EventArgs e)
        {
            
             
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "UPDATE comenzi SET Condition=@cond WHERE Number = @nr AND Name = @nume";
            cmd.Parameters.AddWithValue("@nr", Convert.ToInt32(numarb.Text));
            cmd.Parameters.AddWithValue("@nume", Convert.ToString(numeb.Text));
            cmd.Parameters.AddWithValue("@cond", "Отказ");
            cmd.ExecuteNonQuery();
            cnn.Close();
            conditionb.Text = "Отказ";
            btns();
            refreshgrid();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
             
            if (admin == true)
            {
                SqlConnection cnn;
                cnn = new SqlConnection(Properties.Settings.Default.conn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                string querry;
                if (finish.ForeColor == Color.Red) { querry = "DELETE FROM doneorders WHERE Number = @nr AND Name = @nume"; }
                else { querry = "DELETE FROM comenzi WHERE Number = @nr AND Name = @nume"; }
                cmd.CommandText = querry;
                cmd.Parameters.AddWithValue("@nr", Convert.ToInt32(numarb.Text));
                cmd.Parameters.AddWithValue("@nume", Convert.ToString(numeb.Text));
                cmd.ExecuteNonQuery();
                cnn.Close();
                comenzidatagrid.SelectedCells[0].Selected = true;
                refreshgrid();
            }
            else
            {
                MessageBox.Show("Нужны права Администратора");
            }
        }
       

        private void addtime_Click(object sender, EventArgs e)
        {
            
             
            SqlConnection cnn;
            cnn = new SqlConnection(Properties.Settings.Default.conn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "UPDATE doneorders SET DateIssue=@date, Condition=@cond WHERE Number = @numar AND Name = @numee";
            cmd.Parameters.AddWithValue("@numar", Convert.ToInt32(numarb.Text));
            cmd.Parameters.AddWithValue("@date", dateTime.Value);
            cmd.Parameters.AddWithValue("@cond", "Выдан");
            cmd.Parameters.AddWithValue("@numee", numeb.Text);

            cmd.ExecuteNonQuery();
            cnn.Close();
            dateTime.Visible = false;
            addtime.Visible = false;
            conditionb.Text = "Выдан";
            refreshgrid();
            next.Enabled = true;
            back.Enabled = true;
            comenzidatagrid.Enabled = true;
            reject.Enabled = false;
            delete.Enabled = true;
            addbtn.Enabled = true;
            datepanel.Visible = false;
        }

       
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            dateTime.MinDate = DateTime.Now;
        }

        private void resetboxes_Click(object sender, EventArgs e)
        {
            numarsort.Text = "";
            numesort.Text = "";
        }


        private void Comenzi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main();
            main.Show();
        }


        private void Comenzi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Main main = new Main();
                main.Show();
                e.SuppressKeyPress = true;
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (comenzidatagrid.SelectedCells.Count > 0)
            {
                Edit edit = new Edit(this);
                edit.Show();
                edit.numbertemp = numarb.Text;
                edit.model.Text = telefonb.Text;
                edit.name.Text = numeb.Text;
                edit.mester.Text = mesterlist.Text;
                edit.timer.Enabled = true;
            }
        }

        private void comenzidatagrid_MouseDown(object sender, MouseEventArgs e)
        {
            
             
            if (e.Button != MouseButtons.Right)
            {
                optm.Enabled = false;
                optm.Close();
            }
            else
            {
            optm.Enabled = true;

                var hti = comenzidatagrid.HitTest(e.X, e.Y);
                
                if (hti != DataGridView.HitTestInfo.Nowhere) {
                    comenzidatagrid.ClearSelection();
                    comenzidatagrid.Rows[hti.RowIndex].Selected = true;
                DataGridViewRow selectedRow = comenzidatagrid.Rows[hti.RowIndex]; 
                
                int ap;
                int lucr;
                int cg;
                int scr;

                string tempnr = selectedRow.Cells[1].Value.ToString();
                string tempnum = selectedRow.Cells[2].Value.ToString();
                if (tempnr.Length == 0 || tempnum.Length == 0) { return; }
                else
                {
                    next.Enabled = true;
                    back.Enabled = true;
                    numarb.Text = tempnr;
                    numeb.Text = tempnum;

                    SqlConnection cnn;
                    cnn = new SqlConnection(Properties.Settings.Default.conn);
                    cnn.Open();
                    string query;
                    if (finish.ForeColor == Color.Red) { query = "SELECT * FROM doneorders WHERE Number = @nr AND Name = @nume"; }
                    else { query = "SELECT * FROM comenzi WHERE Number = @nr AND Name = @nume"; }
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@nr", Convert.ToInt32(tempnr));
                    cmd.Parameters.AddWithValue("@nume", Convert.ToString(tempnum));

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        mesterlist.Text = String.Format("{0}", reader["Master"]);
                        contactb.Text = String.Format("{0}", reader["Contact"]);
                        imeib.Text = String.Format("{0}", reader["IMEI"]);
                        if (imeib.Text == "0") imeib.Text = "";
                        telefonb.Text = String.Format("{0}", reader["Model"]);
                        conditionb.Text = String.Format("{0}", reader["Condition"]);
                        receptb.Text = String.Format("{0}", reader["Receipt"]);
                        detailsb.Text = String.Format("{0}", reader["Details"]);
                        problemsb.Text = String.Format("{0}", reader["Problems"]);
                        ap = Convert.ToInt32(reader["Water"]);
                        if (ap == 1) water.Checked = true; else water.Checked = false;
                        lucr = Convert.ToInt32(reader["Reaction"]);
                        if (lucr == 1) reaction.Checked = true; else reaction.Checked = false;
                        cg = Convert.ToInt32(reader["Charger"]);
                        if (cg == 1) charger.Checked = true; else charger.Checked = false;
                        scr = Convert.ToInt32(reader["Scratches"]);
                        if (scr == 1) scratches.Checked = true; else scratches.Checked = false;
                        dataprimb.Value = Convert.ToDateTime(reader["DateReceipt"]);

                        if (conditionb.Text == "В ожидании")
                        {
                            datafin.Visible = false;
                            datafinb.Visible = false;
                            datapred.Visible = false;
                            dataredb.Visible = false;
                            garantieb.Visible = false;
                            grnt.Visible = false;
                            garantie.Visible = false;
                        }
                        if (conditionb.Text == "Отказ")
                        {
                            garantieb.Text = "";
                            datafin.Visible = false;
                            datafinb.Visible = false;
                            datapred.Visible = false;
                            dataredb.Visible = false;
                            garantieb.Visible = false;
                            grnt.Visible = false;
                            garantie.Visible = false;
                        }
                        if (conditionb.Text == "Готов")
                        {
                            datafinb.Value = Convert.ToDateTime(reader["DateFinish"]);
                            garantieb.Text = "";
                            datafin.Visible = true;
                            datafinb.Visible = true;
                            datapred.Visible = false;
                            dataredb.Visible = false;
                            garantieb.Visible = false;
                            grnt.Visible = false;
                            garantie.Visible = false;
                        }
                        if (conditionb.Text == "Выдан")
                        {
                            datafinb.Value = Convert.ToDateTime(reader["DateFinish"]);
                            dataredb.Value = Convert.ToDateTime(reader["DateIssue"]);
                            garantieb.Text = String.Format("{0}", reader["Guarantee"]);
                            garant = Convert.ToInt32(garantieb.Text);
                            datafin.Visible = true;
                            datafinb.Visible = true;
                            datapred.Visible = true;
                            dataredb.Visible = true;
                            garantieb.Visible = true;
                            grnt.Visible = true;
                            garantie.Visible = true;
                        }
                        if (conditionb.Text == "Выдан")
                        {
                            grnt.Visible = true;
                            if ((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days < 0) { grnt.ForeColor = Color.Red; grnt.Text = Convert.ToString(((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days) * (-1)); }
                            else
                          if ((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days == 0) { grnt.ForeColor = Color.Orange; grnt.Text = Convert.ToString((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days); }
                            else
                         if ((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days > 0) { grnt.ForeColor = Color.Green; grnt.Text = Convert.ToString((dataredb.Value.AddDays(garant) - DateTime.Now.Date).Days); }
                        }
                        else
                        {
                            grnt.Visible = false;
                        }

                        priceb.Text = Convert.ToString(reader["Price"]);
                    }
                    cnn.Close();

                    switch (conditionb.Text)
                    {
                        case "Отказ":
                            {
                                next.Text = "Завершить Ремонт"; next.Enabled = true; back.Text = "Вернуть в Ожидании"; back.Enabled = true; reject.Enabled = false; editbtn.Enabled = false;
                                optm.Items[0].Visible = false;
                                optm.Items[1].Text = "Завершить Ремонт";
                                optm.Items[2].Text = "Вернуть в Ожидании";
                                optm.Items[3].Visible = false;

                            }
                            break;
                        case "В ожидании":
                            {
                                next.Text = "Завершить Ремонт"; next.Enabled = true; back.Text = "Вернуть в Ожидании"; back.Enabled = false; reject.Enabled = true; editbtn.Enabled = true;
                                optm.Items[0].Visible = true;
                                optm.Items[1].Text = "Завершить Ремонт";
                                optm.Items[2].Visible = false;
                                optm.Items[3].Visible = true;

                                }
                            break;
                        case "Готов":
                            {
                                next.Text = "Выдать"; next.Enabled = true; back.Text = "Вернуть в Ремонт"; back.Enabled = true; reject.Enabled = false; editbtn.Enabled = true;

                                optm.Items[1].Text = "Выдать";
                                optm.Items[2].Text = "Вернуть в Ремонт";
                                optm.Items[3].Visible = false;
                            }
                            break;
                        default:
                            {
                                next.Text = "Напечатать Документ"; next.Enabled = true; back.Text = "Вернуть в Готовые"; back.Enabled = true; reject.Enabled = false; editbtn.Enabled = false;
                                optm.Items[0].Visible = false;
                                optm.Items[1].Text = "Напечатать Документ";
                                optm.Items[2].Text = "Вернуть в Готовые";
                                optm.Items[3].Visible = false;
                            }
                            break;
                    }
                        
                }
                } else
                { 
                    comenzidatagrid.ClearSelection();
                    outs = true;
                }
            }

        }
        bool outs;
        private void optm_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            optm.Items[0].Visible = true;
            optm.Items[1].Text = "Завершить Ремонт";
            optm.Items[2].Text = "Вернуть в Ожидании";
            optm.Items[2].Visible = true;
            optm.Items[3].Visible = true;
        }

        private void optm_Opening(object sender, CancelEventArgs e)
        {
            

            if (outs == true) { e.Cancel = true; outs = false; }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comenzidatagrid.SelectedCells.Count > 0)
            {
                Edit edit = new Edit(this);
                edit.Show();
                edit.numbertemp = numarb.Text;
                edit.model.Text = telefonb.Text;
                edit.name.Text = numeb.Text;
                edit.mester.Text = mesterlist.Text;
                edit.timer.Enabled = true;
            }
        }

        private void начатьРемонтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comenzidatagrid.SelectedCells.Count > 0)
            {
                if (numarb.Text == "" || numeb.Text == "") { return; }
                else
                {
                    switch (conditionb.Text)
                    {
                        case "В ожидании":
                            {
                                doneform don = new doneform(this);
                                don.Show();
                                don.nume = numeb.Text;
                                don.numar = numarb.Text;
                                don.model.Text = telefonb.Text;
                                don.problems.Text = problemsb.Text;
                                don.details.Text = detailsb.Text;
                                don.price.Text = priceb.Text;
                                btns();
                                refreshgrid();
                            };
                            break;
                        case "Отказ":
                            {
                                doneform don = new doneform(this);
                                don.Show();
                                don.nume = numeb.Text;
                                don.numar = numarb.Text;
                                don.model.Text = telefonb.Text;
                                btns();
                                refreshgrid();
                            };
                            break;
                        case "Готов":
                            {
                                dateTime.Visible = true;
                                addtime.Visible = true;
                                datepanel.Visible = true;
                                comenzidatagrid.Enabled = false;
                                btns();
                                comenzidatagrid.DataSource = getlistgata();
                                comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                                next.Enabled = false;
                                back.Enabled = false;
                                reject.Enabled = false;
                                delete.Enabled = false;
                                addbtn.Enabled = false;
                            }
                            break;
                        case "Выдан":
                            {
                                using (PrintReceipt prt = new PrintReceipt())
                                {


                                    ReportParameter[] para = new ReportParameter[]
                                    {
                                    new ReportParameter("FName",Properties.Settings.Default.NameOrg),
                                    new ReportParameter("FAdress",Properties.Settings.Default.AdressOrg),
                                    new ReportParameter("FPhone",Properties.Settings.Default.ContactOrg),
                                    new ReportParameter("FWork",Properties.Settings.Default.TimeOrg),
                                    new ReportParameter("FLogo", new Uri(Properties.Settings.Default.FileString).AbsoluteUri),
                                    new ReportParameter("FNr",numarb.Text),
                                    new ReportParameter("Reception","("+receptb.Text+")"),
                                    new ReportParameter("Client","("+numeb.Text+")"),
                                    new ReportParameter("Data",dataredb.Text),
                                    new ReportParameter("Name",numeb.Text),
                                    new ReportParameter("Phone",contactb.Text),
                                    new ReportParameter("Model",telefonb.Text),
                                    new ReportParameter("IMEI",imeib.Text),
                                    new ReportParameter("Service", detailsb.Text),
                                    new ReportParameter("Price",priceb.Text),
                                    };
                                    prt.reportViewer1.LocalReport.EnableExternalImages = true;
                                    prt.reportViewer1.LocalReport.SetParameters(para);
                                    prt.ShowDialog();
                                }

                            }
                            break;

                    }


                }
            }
        }

        private void вернутьВОжиданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comenzidatagrid.SelectedCells.Count > 0)
            {
                switch (conditionb.Text)
                {

                    case "Отказ":
                        {

                            breject();
                            conditionb.Text = "В ожидании";
                            btns();
                            if (comenzidatagrid.SelectedCells.Count == 0)
                            {
                                comenzidatagrid.SelectedCells[0].Selected = true;
                            }
                            refreshgrid();
                            comenzidatagrid.DataSource = getlist();
                            comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                        }
                        break;
                    case "Готов":
                        {

                            bfinish();
                            conditionb.Text = "В ожидании";
                            btns();
                            if (comenzidatagrid.SelectedCells.Count == 0)
                            {
                                comenzidatagrid.SelectedCells[0].Selected = true;
                            }
                            refreshgrid();
                            comenzidatagrid.DataSource = getlistgata();
                            comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                        }
                        break;
                    case "Выдан":
                        {
                            bissue();
                            conditionb.Text = "Готов";
                            btns();
                            if (comenzidatagrid.SelectedCells.Count == 0)
                            {
                                comenzidatagrid.SelectedCells[0].Selected = true;
                            }
                            refreshgrid();
                            comenzidatagrid.DataSource = getlistgata();
                            comenzidatagrid.Sort(comenzidatagrid.Columns[0], ListSortDirection.Ascending);
                        }
                        break;

                }
            }
        }

        private void отказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             
            if (comenzidatagrid.SelectedCells.Count > 0)
            {
                SqlConnection cnn;
                cnn = new SqlConnection(Properties.Settings.Default.conn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "UPDATE comenzi SET Condition=@cond WHERE Number = @nr AND Name = @nume";
                cmd.Parameters.AddWithValue("@nr", Convert.ToInt32(numarb.Text));
                cmd.Parameters.AddWithValue("@nume", Convert.ToString(numeb.Text));
                cmd.Parameters.AddWithValue("@cond", "Отказ");
                cmd.ExecuteNonQuery();
                cnn.Close();
                conditionb.Text = "Отказ";
                btns();
                refreshgrid();
            }
        }

        private void удалитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             
            if (comenzidatagrid.SelectedCells.Count > 0)
            {
                if (admin == true)
                {
                    SqlConnection cnn;
                    cnn = new SqlConnection(Properties.Settings.Default.conn);
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    string querry;
                    if (finish.ForeColor == Color.Red) { querry = "DELETE FROM doneorders WHERE Number = @nr AND Name = @nume"; }
                    else { querry = "DELETE FROM comenzi WHERE Number = @nr AND Name = @nume"; }
                    cmd.CommandText = querry;
                    cmd.Parameters.AddWithValue("@nr", Convert.ToInt32(numarb.Text));
                    cmd.Parameters.AddWithValue("@nume", Convert.ToString(numeb.Text));
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    comenzidatagrid.SelectedCells[0].Selected = true;
                    refreshgrid();
                }
                else
                {
                    MessageBox.Show("Нужны права Администратора");
                }
            }
        }
    }

}



