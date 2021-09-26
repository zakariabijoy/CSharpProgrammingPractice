using Microsoft.Reporting.WinForms;
using rdlcTest.dstestTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rdlcTest
{
    public partial class rptViewer : Form
    {
        public rptViewer()
        {
            InitializeComponent();
        }

        private void rptViewer_Load(object sender, EventArgs e)
        {

            string exeFolder = Path.GetDirectoryName(Application.ExecutablePath);
            string reportPath = exeFolder + "rptTest.rdlc";
            
           // ReportDataSource rds = new ReportDataSource("dstest", )

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.ReportPath = reportPath;
            this.reportViewer1.RefreshReport();

        }
    }
}
