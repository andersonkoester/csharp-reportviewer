using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportViewer.Views;
using ReportViewer.Model;

namespace ReportViewer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void openReport001_Click(object sender, EventArgs e) {
            ReportModel rm = new ReportModel();
            rm.Dummie = "DataBinding";
            Report001 report = new Report001(rm);
            report.ShowDialog();
        }
    }
}
