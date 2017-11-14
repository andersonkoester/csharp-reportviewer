using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportViewer.Model;
using Microsoft.Reporting.WinForms;

namespace ReportViewer.Views {
    public partial class Report001 : Form {
        private ReportModel rm;

        public Report001(ReportModel rm) {
            this.rm = rm;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("textDynamic", "Loucura Pura");
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e) {
        }
    }
}
