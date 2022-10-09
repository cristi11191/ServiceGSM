using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceGSMApp
{
    public partial class PrintReceipt : Form
    {

        string _name, _adress, _phone, _work, _logo;

        private void PrintReceipt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

                // prevent child controls from handling this event as well
                e.SuppressKeyPress = true;
            }
        }

        public PrintReceipt()
        {
            InitializeComponent();
            _name =  Properties.Settings.Default.NameOrg;
            _adress = Properties.Settings.Default.AdressOrg;
            _phone = Properties.Settings.Default.ContactOrg;
            _work = Properties.Settings.Default.TimeOrg;
            _logo = Properties.Settings.Default.FileString;
        }

        private void PrintReceipt_Load(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("FName",_name),
                new ReportParameter("FAdress",_adress),
                new ReportParameter("FPhone",_phone),
                new ReportParameter("FWork",_work),
                new ReportParameter("FLogo", new Uri(_logo).AbsoluteUri),

            };
            
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();

        }
    }
}
